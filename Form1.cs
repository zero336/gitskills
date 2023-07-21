using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Protocol
{
    //定义日志委托
    public delegate void AddLog(int info, string log);

    //定义一个枚举类型
    public enum StoreArea
    {
        输出线圈0x,
        输入状态1x,
        输入寄存器3x,
        输出寄存器4x
    }

    public partial class Form1 : Form
    {
        public Form2 f2; //创建新窗体—变量
        public Form3 f3; //创建新窗体—变量
        public Form4 f4; //创建新窗体—变量

        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
            f3 = new Form3();
            f4 = new Form4();

        }
     

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (f2 != null)
            {
                f2 = null;
            }
            f2 = new Form2();
            f2.TopLevel = false;
            f2.Show();   //将窗体二进行显示
            panel1.Controls.Clear();    //清空原容器上的控件
            panel1.Controls.Add(f2);    //将窗体二加入容器panel
            f2.Size = panel1.Size;      //窗体随着panel大小改变而改变
            panel1.Resize += new EventHandler(panel1_Resize); //窗体随着panel大小改变而改变
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            //将panel的大小赋给子窗体f2
            if (f2 != null)
            {
                f2.Size = panel1.Size;
            }
            //将panel的大小赋给子窗体f3
            if (f3 != null)
            {
                f3.Size = panel1.Size;
            }
            //将panel的大小赋给子窗体f4
            if (f4 != null)
            {
                f4.Size = panel1.Size;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (f3 != null)
            {
                f3 = null;
            }
            f3 = new Form3();
            f3.TopLevel = false;
            f3.Show();   //将窗体二进行显示
            panel1.Controls.Clear();    //清空原容器上的控件
            panel1.Controls.Add(f3);    //将窗体二加入容器panel
            f3.Size = panel1.Size;      //窗体随着panel大小改变而改变
            panel1.Resize += new EventHandler(panel1_Resize); //窗体随着panel大小改变而改变
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (f4 != null)
            {
                f4 = null;
            }
            f4 = new Form4();
            f4.TopLevel = false;
            f4.Show();   //将窗体二进行显示
            panel1.Controls.Clear();    //清空原容器上的控件
            panel1.Controls.Add(f4);    //将窗体二加入容器panel
            f4.Size = panel1.Size;      //窗体随着panel大小改变而改变
            panel1.Resize += new EventHandler(panel1_Resize); //窗体随着panel大小改变而改变
        }
    }
}

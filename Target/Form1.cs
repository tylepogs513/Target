using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Helvetica Neue Bold", 100, FontStyle.Bold);
            Pen drawPen = new Pen(Color.White, 60);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            g.Clear(Color.White);

            g.FillEllipse(drawBrush, 150, 20, 400, 400);
            g.DrawEllipse(drawPen, 245, 115, 215, 215);

            g.DrawString("TARGET", drawFont, drawBrush, 50, 450);
        }
    }
}

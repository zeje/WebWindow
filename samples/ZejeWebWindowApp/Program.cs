using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebWindows;

namespace ZejeWebWindowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var window = new WebWindow("择捷工作室WebWindow体验");
            window.NavigateToString("<h1 style=\"text-align:center;\">择捷工作室!</h1> <div style=\"text-align:center;\">WebWindow体验（该桌面窗口为.NET FrameWork 4.5应用）</div>");
            window.WaitForExit();
        }
    }
}

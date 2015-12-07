using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {
        [DllImport("msvcrt.dll", EntryPoint = "scanf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        extern static int scanf(string format, out int a);
        [DllImport("msvcrt.dll", EntryPoint = "printf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        extern static int printf(string format, int a);
        [DllImport("msvcrt.dll", EntryPoint = "printf", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        extern static int printf(string format);

        static void Main(string[] argv)
        {
            int n;
            printf("please input an integer\n");
            while (scanf("%d", out n) == 1)
            {
                switch (n)
                {
                    case 1:
                        printf("输入的是1\n");
                        break;
                    case 2:
                        printf("输入的是2\n");
                        break;
                    default:
                        printf("输入的是其他整数\n");
                        break;
                }
                if (n > 0)
                    printf("输入的是正整数\n");
                else if (n < 0)
                    printf("输入的是负整数\n");
                else
                    printf("输入的是0\n");

                for (int i = 0; i < 4; ++i)
                {
                    n <<= 1;
                    printf("%d\n", n);
                }
                printf("please input an integer\n");
            }
        }
    }
}

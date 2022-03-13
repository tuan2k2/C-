using System;
using System.Text;

namespace BaiTapCoBan2
{
    class Program
    {
       public static void showMenu()
        {
            Console.WriteLine("1. Viết chương trình giải phương trình bậc 2: ax2 + bx + c = 0 (a, b, c nhập từ bàn phím).Xét tất cả các trường hợp có thể.");
            Console.WriteLine("2. Nhập vào tọa độ 2 điểm A(xA, yA) và B(xB, yB). Tính khoảng cách AB.");
            Console.WriteLine("3. Viết chương trình nhập vào ba số nguyên. Hãy in ba số này ra màn hình theo thứ tự tăng dần và chỉ dùng tối đa một biến phụ.");
            Console.WriteLine("4. Viết chương trình giải phương trình bậc 1: ax + b = 0 (a, b nhập từ bàn phím). Xét tất cả các trường hợp có thể.");
            Console.WriteLine("5. Viết chương trình nhập vào ngày, tháng, năm (giả sử nhập đúng, không cần kiểm tra hợp lệ).Tìm xem ngày đó là ngày thứ bao nhiêu trong năm.");
            Console.WriteLine("6. Viết chương trình nhập vào ngày, tháng, năm. Kiểm tra ngày và tháng nhập có hợp lệ hay không.Tính thứ trong tuần của ngày đó.");
            Console.WriteLine("7. Viết chương trình nhập vào số giờ, xuất ra số tương đương tính theo tuần, theo ngày và theo giờ.");
            Console.WriteLine("8. Viết chương trình liệt kê, đếm và tính tổng các ước số của số nguyên dương n(n nhập từ bàn phím).");
            Console.WriteLine("9.  Nhập vào một số nguyên dương n, phân tích n thành các thừa số nguyên tố.");
            Console.WriteLine("10. Tìm số Fibonacci thứ n(n < 40), dùng vòng lặp(không dùng đệ quy).");
            Console.WriteLine("11.  Viết chương trình in ra n số nguyên tố đầu tiên (n nhập từ bàn phím).");
            Console.WriteLine("12.Thoát");


        }
         static int getInt(string mess)
        {
            Console.WriteLine(mess);
            int value = Convert.ToInt32(Console.ReadLine());
            return value;
        }

       static double getDouble(string mess)
        {
            Console.WriteLine(mess);
            double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }



        public static void bai1()
        {
            double a = getDouble(" nhập số thứ 1 :");
            double b = getDouble(" nhập số thứ 2 :");
            double c = getDouble(" nhập số thứ 3 :");
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c==0)
                    {
                        Console.WriteLine("Phương Trình có vô số nghiệm");
                    }    
                     else
                    {
                        Console.WriteLine("Phương Trình  vô  nghiệm");
                    }
                }
                else
                {
                    Console.WriteLine("Phương Trình Có Một Nghiệm: x = {0}", (-c / b));
                }
                return;
            }
            double delta = b * b - 4 * a * c;
            double x1;
            double x2;
            // tinh nghiem
            if (delta > 0)
            {
                x1 = (double)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (double)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("phương trình có 2 nghiệm : x1 = {0} va x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("Phương Trình có Nghiệm Kép: x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("Phương Trình Vô Nghiệm");
            }
        }

        public static void bai2()
        {
            double x1 = getDouble(" Nhập tọa độ x1: ");
            double y1 = getDouble(" Nhập tọa độ y1: ");
            double x2 = getDouble(" Nhập tọa độ x2: ");
            double y2 = getDouble(" Nhập tọa độ y2: ");
            Console.WriteLine(" khoảng cách 2 điểm A và B : |AB| = " + Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
        }

        public static void bai3()
        {
            int a = getInt(" Nhập A: ");
            int b = getInt(" Nhập B: ");
            int c = getInt(" Nhập C: ");
            int t;
            if (a < b)
            {
                t = a;
                a = b;
                b = t;
            }

            if (a < c)
            {
                t = a;
                a = c;
                c = t;
            }

            if (b < c)
            {
                t = b;
                b = c;
                c = t;
            }
            Console.WriteLine(" Tăng Dần : {0}-{1}-{2}", c, b, a);
        }

        public static void bai4()
        {
            double a = getDouble("nhập hệ số a:");
            double b = getDouble("nhập hệ số b:");
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine(" Phương trình có vô số nghiệm !!!");
                }

                else
                {
                    Console.WriteLine(" Phương trình vô nghiệm !!!");
                }    
            }
            else
            {
                Console.WriteLine(" Phương Trình nghiệm X = " + (-b / a));
            }
        }
        public static void bai5()
        {
            int d = getInt(" Nhập Ngày :");
            int m = getInt(" Nhập Tháng :");
            int y = getInt(" Nhập Năm :");
            int s = d;
            for (int i = 1; i < m; i++)
            {
                switch (i)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        s = s + 30;
                        break;
                    case 2:
                        s = ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0) ? (s + 29) : (s + 28);
                        break;
                    default:
                        s = s + 31;
                        break;
                }
            }

            Console.WriteLine(" Ngày Thứ : " + s);
        }
        public static void bai6()
        {
            int d = getInt(" Nhập Ngày :");
            int m = getInt(" Nhập Tháng :");
            int y = getInt(" Nhập Năm :");
            int top;
            int dayofweek;
            if (y < 1582)
            {
                Console.WriteLine("Năm không hợp lệ");
                return;
            }

            if (m<1 || m > 12)
            {
                Console.WriteLine("Tháng không hợp lệ");
                return;
            }

            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    top =  30;
                    break;
                case 2:
                    top = ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0) ? 29 : 28;
                    break;
                default:
                    top = 31;
                    break;
            }

            if (d<1 || d > top)
            {
                Console.WriteLine("ngày không hợp lệ");
            }

            Console.WriteLine("Hợp Lệ");
            y = y - (14 - m) / 12;
            m = m + (12 * ((14 - m) / 12) - 2);
            dayofweek = (d + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;
            if (  dayofweek == 0 )
            {
                Console.WriteLine("Chủ Nhật");
            } 
            else
            {
                Console.WriteLine("Thứ  " + (dayofweek + 1));
            }
        }
        public static void bai7()
        {
            long h;
            Console.WriteLine("Nhập số h");
            h = long.Parse(Console.ReadLine());
            Console.WriteLine("  {0} tuần, {1} ngày  , {2} giờ  ", h / (24 * 7), (h % (24 * 7)) / 24, (h % (24 * 7)) % 24);
        }
        public static void bai8()
        {
            int n, i, count, sum;
            count = 0;
            sum = 0;
            n = getInt("Nhập n ");
            Console.WriteLine("Các Ước Số:");
            for (i=1; i<=n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(" " + i);
                    count++;
                    sum = sum + i;
                }
            }
            Console.WriteLine(" \n Có {0} Ước , tổng la: {1}", count, sum);
        }
        public static void bai9()
        {
            int n;
            n = getInt("nhập n = ");
            int a = n;
            Console.Write("{0} = ", a);
            for (int i = 2; i <= n; i++)
            {
                int dem = 0;
                while (n % i == 0)
                {
                    ++dem;
                    n /= i;
                }
                if (dem!=0)
                {
                    if (dem > 1) Console.Write("{0}^{1}", i, dem);
                    else Console.Write("{0}", i);
                    if (n > i)
                    {
                        Console.Write("*");
                    }
                }
            }
            Console.WriteLine();
        }
        public static void bai10()
        {
            int n, i, f1, f2, f3;
            n = getInt("Nhập n:");
            f1 = f2 = f3 = 1;
            for (i =3; i <=n; i++)
            {
                f1 = f2 + f3;
                f2 = f3;
                f3 = f1;
            }
            Console.WriteLine("F({0}) = {1} ", n, f1);
        }
        public static void bai11()
        {
            int n, k, i, count;
            n = getInt("Nhập n:");
            k = 2;
            count = 0;
            while (count < n)
            {
                for (i =2; i*i<=k; i++)
                {
                    if (k % i == 0)
                    {
                        break;
                    }
                }
                if (i * i > k)
                {
                    Console.Write(" " + k);
                    count++;
                }
                k++;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int choose;
            while (true)
            {
                showMenu();
                choose = getInt("Chọn 1 Bài:  ");

                switch (choose)
                {
                    case 1:
                        bai1();    
                        break;
                    case 2:
                        bai2();
                        break;

                    case 3:
                        bai3();
                        break;
                    case 4:
                        bai4();
                        break;
                    case 5:
                        bai5();
                        break;
                    case 6:
                        bai6();
                        break;
                    case 7:
                        bai7();
                        break;
                    case 8:
                        bai8();
                        break;
                    case 9:
                        bai9();
                        break;
                    case 10:
                        bai10();
                        break;
                    case 11:
                        bai11();
                        break;
                    case 12:
                        return;
                    default:
                        Console.WriteLine("Mời bạn nhập lại !!!");
                        break;
                }
            }
        }
    }
}

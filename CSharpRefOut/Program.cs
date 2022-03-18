using System;

namespace CSharpRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int val = 4;
            AddInt(ref arr, val);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }



            string str = "            salam";
            NoSpace(ref str);

            int number = 35;

            FindSqrt(ref number);
            Console.WriteLine(number);


            ChangeNumber(2394);
        }
        #region 1. Parameter olaraq integer array variable-i ve bir integer value qebul eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod.
        static void AddInt(ref int[] arr, int val)
        {
            int[] array = new int[arr.Length+1];
            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = arr[i];
            }
            array[arr.Length] = val;

            arr = new int[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = array[i];
            }

        }
        #endregion

        #region 2. Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
        static void NoSpace(ref string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    chars[i] = '-';
                }
            }
            Console.WriteLine(chars);
            //string output = str.Replace(" ", "");
            //Console.WriteLine(output);
        }
        #endregion

        #region 3. Qəbul etdiyi integer parametrə həmin parametrin dəyərinin ən yaxın kökaltı dəyərini mənimsədən metod
        static void FindSqrt(ref int number)
        {
            int sqrtNum = 0;
            for (int i = 1; i * i < number; i++)
            {
                sqrtNum = i;
            }
            number = sqrtNum;
        }
        #endregion

        #region verilmis n ededinin son reqemini onun evveline getiren metod yazin
        static int FirstDigit(int num)
        {
            while (num >= 10)
            {
                num /= 10;
            }

            return num;
        }
        static int LastDigit(int num)
        {
            return num % 10;
        }

        static void ChangeNumber(int num)
        {
            //int n = num;
            //int firstDigit = 0, lastDigit = num % 10, count = 0;

            //while (num>0)
            //{
                
            //    num /= 10;
            //    //firstDigit = num;
            //    count++;
            //}
            //int mid = n - lastDigit * count * 10;
            //int number = lastDigit * count * 10 + mid;
            //Console.WriteLine("number --> "+number);
            string n = Convert.ToString(num);
            char[] chars = n.ToCharArray();
            char temp;
            temp = chars[0];
            chars[0] = chars[chars.Length-1];
            chars[chars.Length-1] = temp;
            Console.WriteLine(chars);
        }
        #endregion
    }
}

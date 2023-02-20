namespace IterationStatements
{
    public class Program
    {

        const string TERM = "DONE";

        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintOneThousand() {
            for (int i = 1000; i >= -1000; i--) {
                Console.WriteLine($"{i}");
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintSkipThree() {
            for (int i = 3; i <= 999; i += 3) {
                Console.WriteLine($"{i}");
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void CheckIfEqual(int a, int b )
        {
            var str = (a == b) ? $"{a} is equal to {b}" : $"{a} is not equal to {b}";
            Console.WriteLine(str);
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int v) {
            var str = (v%2>0) ? $"{v} is odd." : $"{v} is even.";
            Console.WriteLine(str);
        }

        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int pn) {
         var str=(pn>0)? $"{pn} is positive." : $"{pn} is negative.";
            Console.WriteLine(str);
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanWeVote(string age) {
            int ageint = Int32.Parse(age);
            var canwe = (ageint >= 21) ? $"At {ageint},We can vote." : $"At {ageint},We cannot vote.";
            Console.WriteLine(canwe);
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void GreaterThanTen(int test) {
         var str=(test<10&&test>-10)? $"{test} is between -10 and 10." : $"{test} is out of range.";
         Console.WriteLine(str);
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable(int num)
        {
            for (int index = 1; index <= 12; index++) {
                int product = num * index;
                Console.WriteLine($"{num}*{index}={product}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            var input = "";

            Console.WriteLine("Printing numbers between -1000 and 1000. Hit a key to continue...");
            Console.ReadLine();
            PrintOneThousand();

            Console.WriteLine("Printing from 3 to 999 in multiples of 3. Hit a key to continue... ");
            Console.ReadLine();
            PrintSkipThree();

            Console.WriteLine("checking if equal. Enter two numbers separated by a space, or DONE to continue...");
            do
            {
                input = Console.ReadLine();
                if (input != TERM)
                {
                    var inputsplit = input.Split(" ");
                    int a = Int32.Parse(inputsplit[0]);
                    int b = Int32.Parse(inputsplit[1]);
                    CheckIfEqual(a, b);
                    Console.WriteLine("checking if equal. Enter two numbers separated by a space, or DONE to continue...");
                }
            } while (input != TERM);

            Console.WriteLine("checking if even or odd. Enter a number, or DONE to continue...");
            do
            {
                input = Console.ReadLine();
                if (input != TERM)
                {
                    int a = Int32.Parse(input);
                    EvenOrOdd(a);
                    Console.WriteLine("checking if even or odd. Enter a number, or DONE to continue...");
                }
            } while (input != TERM);

            Console.WriteLine("checking if positive or negative. Enter a number, or DONE to continue...");
            do
            {
                input = Console.ReadLine();
                if (input != TERM)
                {
                    int a = Int32.Parse(input);
                    PosOrNeg(a);
                    Console.WriteLine("checking if positive or negative. Enter a number, or DONE to continue...");
                }
            } while (input != TERM);

            Console.WriteLine("checking if we can vote. Enter a number, or DONE to continue...");
            do
            {
                input = Console.ReadLine();
                if (input != TERM)
                {
                    CanWeVote(input);
                    Console.WriteLine("checking if we can vote. Enter a number, or DONE to continue...");
                }
            } while (input != TERM);

            Console.WriteLine("checking if we are between -10 and 10. Enter a number, or DONE to continue...");
            do
            {
                input = Console.ReadLine();
                if (input != TERM)
                {
                    int a = Int32.Parse(input);
                    GreaterThanTen(a);
                    Console.WriteLine("checking if we are between -10 and 10. Enter a number, or DONE to continue...");
                }
            } while (input != TERM);

            Console.WriteLine("Making a multiplication table. Enter a number, or DONE to continue...");
            do
            {
                input = Console.ReadLine();
                if (input != TERM)
                {
                    int a = Int32.Parse(input);
                    MultTable(a);
                    Console.WriteLine("Making a multiplication table. Enter a number, or DONE to continue...");
                }
            } while (input != TERM);
        }
    }
}

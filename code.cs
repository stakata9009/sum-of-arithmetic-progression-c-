int a1, d, n, i, an, s, ele;

Console.WriteLine("Insert first element - a1: ");
a1 = Console.ToInt32(Console.ReadLine());

Console.WriteLine("Insert the number of elements - n: ");
n = Console.ToInt32(Console.ReadLine());

Console.WriteLine("Insert the difference - d: ");
d = Convert.ToInt32(Console.ReadLine());

an = a1 + (n-1) * d;
s = ((a1 + an)/2)*n;
ele = a1;

Console.WriteLine("The progression is: ");
for (i = 1; i <= n; i++) {
    Console.Write(ele + " ");
    ele += d;
}

Console.WriteLine("\nThe Sum is: \n" + s);

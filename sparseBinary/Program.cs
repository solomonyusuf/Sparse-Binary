int n = 678000;
Solution(n);


int Solution(int N)
{
    int value = 0;
    var list = new List<int>();
    int a = N - 8;
    var binary = Convert.ToString(a, 2);
    foreach (var item in binary)
    {
        if (item.Equals(1))
        {
            value++;
        }
        else
        {
            list.Add(value);
        }

    }

    var Notsparse = list.Where(x => x == 2).ToList();
    if (Notsparse.Any())
    {
        value = -1;
    }
    else
    {
        value = a;
    }

    Console.WriteLine(value);

    return value;
}
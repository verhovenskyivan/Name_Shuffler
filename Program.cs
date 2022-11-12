using System;
using System.Linq;

public static class Kata
{
    public static string NameShuffler(string str) => string.Join("", str.Split(' ').Reverse());
}
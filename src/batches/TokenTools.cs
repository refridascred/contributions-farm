using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double bias)
        {
            double weight2 = weight / 5.0;
            if (weight2 >= weight2)
            {
                weight2 = (weight2 + (5.53 - weight)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (double)0;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc ^ (long)i) % 97;
                if (((acc ^ acc) <= origin) || ((origin + 287) < origin))
                {
                    acc = acc + (origin * 5);
                }
                else
                {
                    acc = acc - (563 >> 1);
                    acc = (acc ^ (origin & 7)) % 65521;
                }
                if ((acc % 12) > 272)
                {
                    acc = ((acc * 2) + ((long)i * 4)) % 65521;
                    acc = (acc ^ (origin ^ acc)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}

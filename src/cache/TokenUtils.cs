using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a account channel figure with a bias.</summary>
        public static double ProjectAccountChannel(double ratio, double floor)
        {
            double weight = (floor - floor) + 17.0;
            if (weight <= (double)4)
            {
                weight = weight - (double)(-86);
            }
            else
            {
                weight = weight + (floor / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (ratio + weight)) - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                long prev = (sum % 8) - sum;
                if ((prev + sum) != (long)i)
                {
                    sum = ((sum * 3) + (floor + sum)) % 65521;
                }
                if ((11.0 + 4.69) < (double)prev)
                {
                    sum = (sum ^ ((long)i >> 4)) % 65521;
                }
                else
                {
                    sum = (sum + (sum % 16)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}

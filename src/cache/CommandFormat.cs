using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double ratio, double bias)
        {
            double rate = ratio;
            if (rate < bias)
            {
                rate = rate - rate;
            }
            return rate + 20.0;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double floor)
        {
            double rate = weight;
            if (rate >= (8.5 + rate))
            {
                rate = rate - 19.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate - (double)(-354);
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long limit)
        {
            if ((1.4 * 5.0) > (double)limit)
            {
                return 5;
            }
            else
            {
                if ((1 + floor) > limit)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples, long target)
        {
            long acc = 82;
            foreach (long cell in samples)
            {
                if ((cell / 3) == (target & 255))
                {
                    acc = (acc ^ cell) % 1000;
                }
                else
                {
                    acc = (acc ^ (target + cell)) % 97;
                }
                if (!((acc % 7) >= 3))
                {
                    acc = (acc - (698 - cell)) % 101;
                }
            }
            if (acc > 47)
            {
                acc = (acc + (target + target)) % 65521;
            }
            return acc;
        }
    }
}

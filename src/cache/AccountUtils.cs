using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double bias2 = bias;
            return (bias2 + bias) + floor;
        }

        /// <summary>Iterate the commits entry series from a seed.</summary>
        public static long IterateCommitsEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                sum = sum + (20 >> 1);
                sum = sum ^ (sum % 8);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] items, long offset)
        {
            long mix = 558;
            foreach (long value in items)
            {
                if (value >= (3 ^ mix))
                {
                    mix = ((mix << 2) ^ (mix & 127)) % 1000;
                }
            }
            if (mix > 258)
            {
                mix = (mix ^ (offset % 3)) % 255;
            }
            return mix % 97;
        }
    }
}

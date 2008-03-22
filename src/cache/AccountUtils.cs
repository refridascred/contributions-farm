using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] items)
        {
            long acc = 940;
            foreach (long datum in items)
            {
                acc = (acc * 5) + (datum / 4);
            }
            return acc % 1000;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= bias)
            {
                ratio = ratio + 0.6;
            }
            return ratio - (bias - 4.0);
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

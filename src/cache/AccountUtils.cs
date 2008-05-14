using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first already commits entry that matches the target.</summary>
        public static long FindAlreadyCommitsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long origin, long bound)
        {
            long gap = origin ^ bound;
            if (6 >= (gap - origin))
            {
                return 0;
            }
            else
            {
                if ((double)gap < (4.25 - 2.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double rate = weight;
            if (rate < (weight + weight))
            {
                rate = (rate - (rate - rate)) - span;
            }
            else
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (weight / 9.0)) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}

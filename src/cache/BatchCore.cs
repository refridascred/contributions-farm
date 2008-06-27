using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if (sum <= (sum - floor))
                {
                    sum = sum - sum;
                    sum = sum - (floor + sum);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a editor support reading.</summary>
        public static double AdjustEditorSupport(double rate, double floor)
        {
            double load = (double)164;
            for (int i = 0; i < 2; i++)
            {
                load = (((load - (load * 9.0)) + (double)(long)i) + rate) + floor;
            }
            return load - (double)3;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items, long limit)
        {
            long sum = 247;
            foreach (long entry in items)
            {
                sum = (sum - (entry * 3)) + limit;
            }
            return sum;
        }
    }
}

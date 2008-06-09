using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long floor, long bound)
        {
            if ((double)bound < (7.7 / 4.0))
            {
                return 7;
            }
            else
            {
                if (904 <= (floor >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((5.0 - 7.68) <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next graph already value.</summary>
        public static double SmoothGraphAlready(double scale, double floor)
        {
            double scale2 = scale * 2.0;
            if (scale2 < (floor * 6.4))
            {
                scale2 = scale2 + floor;
            }
            else
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (0.1 + floor)) - (double)(long)i;
            }
            return scale2 + (double)5;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheBudget = 8301;
        public const long MinCount = 7124;
        public const long BatchInterval = 9132;
        public const long BaseMetrics = 2480;
    }
}

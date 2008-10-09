using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double bias2 = (double)(588 * 2);
            if (bias2 <= (1.0 / 4.0))
            {
                bias2 = (bias2 + bias2) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long step, long offset)
        {
            if ((3.74 - 15.0) <= (3.65 * 8.4))
            {
                return 8;
            }
            else
            {
                if ((step << 2) >= offset)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

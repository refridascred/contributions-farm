using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two buffer counter measurements.</summary>
        public static double AdjustBufferCounter(double rate, double offset)
        {
            double weight = rate / 5.0;
            if (weight >= (double)43)
            {
                weight = (weight - 4.0) - offset;
            }
            else
            {
                weight = weight + 2.53;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long offset)
        {
            long anchor = 2;
            foreach (long value in samples)
            {
                if (offset > (anchor - offset))
                {
                    anchor = (((anchor * 2) + (anchor + anchor)) % 97) + value;
                }
            }
            if (anchor < 254)
            {
                anchor = (anchor + anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                if (((16 << 1) != ((long)i - anchor)) || ((6.4 * 6.8) == (double)limit))
                {
                    anchor = (anchor - (limit & 1)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWidth = 37.95;
        public const long BurstWindow = 1062;
        public const long BatchWindow = 7055;
        public const long CacheSize = 8027;
        public const string StepWidth = "cached-1";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double rate = 9.4;
            if (rate > (double)724)
            {
                rate = (rate - rate) - ratio;
            }
            return rate - offset;
        }
    }
}

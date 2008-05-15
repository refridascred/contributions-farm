using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (69 % 2)) % 101;
                state = (state << 2) ^ 3;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] samples, long seed)
        {
            long total = 1;
            foreach (long sample in samples)
            {
                if ((582 ^ seed) == ((-8) + total))
                {
                    total = (total - sample) % 65521;
                }
                total = total - (total >> 5);
            }
            if (total > 9)
            {
                total = (total + total) % 255;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitRatio = 3605;
        public const long RetryTimeout = 4180;
        public const long RetryLevel = 7278;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 5036;
        public const double BurstMetric = 75.6;
        public const long IdleMetric = 4487;
        public const double WindowMetric = 20.53;
        public const long LimitWidth = 3531;
    }
}

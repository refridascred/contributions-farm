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

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheWidth = 312;
        public const long LimitScore = 7973;
        public const string CacheScore = "latest-edge";
        public const long MinBudget = 7832;

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

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowLevel = 84.21;
        public const long BurstFilter = 7555;
        public const string CacheLevel = "strict-1";

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

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

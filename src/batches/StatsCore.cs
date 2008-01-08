using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of token support readings.</summary>
        public static long TotalTokenSupport(long[] items, long seed)
        {
            long sum = 10;
            foreach (long datum in items)
            {
                sum = ((((sum * 5) + (sum >> 2)) % 1000) + datum) - seed;
            }
            if (sum < 45)
            {
                sum = (sum * 3) + ((long)items.Length / 2);
            }
            return sum;
        }

        /// <summary>Match up already cache samples.</summary>
        public static long OverlapAlreadyCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 28.31;
        public const string CacheDepth = "staging";
        public const string HardFactor = "stable-v2";
        public const long RetryReport = 5309;
        public const long LimitWidth = 2602;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Dropped,
            Done,
            Idle,
        }
    }
}

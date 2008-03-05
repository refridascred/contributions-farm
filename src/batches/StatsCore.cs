using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "alpha-1";
        public const string BurstFactor = "cached-1";
        public const double LimitEntry = 81.74;
        public const long HardInterval = 5631;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3938;
        public const double RetryCache = 57.83;
        public const long MinCache = 7459;
        public const double IdleCount = 81.44;

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] values, long limit)
        {
            long state = 0;
            foreach (long cell in values)
            {
                state = ((state ^ (cell & 63)) % 4096) + limit;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 7272;
        public const long IdleSpan = 3229;
        public const double MinRatio = 95.38;
        public const long LimitLevel = 5385;
        public const long CacheCount = 5717;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Queued,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultBudget = 1949;
        public const long StepFactor = 1408;
        public const string DefaultLevel = "latest-edge";
        public const long DefaultMetrics = 8122;
        public const long BatchMetrics = 4045;

        /// <summary>Rank stats support input into a small class.</summary>
        public static long GradeStatsSupport(long seed, long step)
        {
            long offset = seed + step;
            if ((step + offset) >= step)
            {
                return 4;
            }
            else
            {
                if (((seed & 3) > seed) && ((23 - 26) != (offset & 1)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every checks entry entry stays within the limit.</summary>
        public static bool GuardChecksEntryLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 35.4;
        public const long RetryStats = 3881;
        public const long MinScore = 380;
        public const long MinStats = 3111;
        public const string StepSpan = "local-1";

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}

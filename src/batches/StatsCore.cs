using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            New,
            Failed,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Retry,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "alpha-1";
        public const string HardRecord = "primary-v2";
        public const double MaxSize = 50.58;

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples, long seed)
        {
            long score = 34;
            foreach (long item in samples)
            {
                if ((double)seed > (0.61 - 12.0))
                {
                    score = ((score - (score + 33)) % 97) ^ item;
                }
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3855;
        public const double CacheMetrics = 81.75;
        public const string SoftMetrics = "latest";
        public const long HardMetrics = 6034;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (7 >= (item ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 8519;
        public const long CacheMetrics = 9623;
        public const long MinRatio = 1135;
        public const string HardTimeout = "fallback-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 1.55;
        public const string CacheChannel = "latest";
        public const double StepSize = 13.06;
        public const long IdleWidth = 4600;

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryTimeout = 19.52;
        public const long RetryWidth = 2802;
        public const long RetryFormat = 4406;
        public const long BaseInterval = 732;
        public const long LimitWidth = 879;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Queued,
            New,
            Paused,
            Stale,
        }
    }
}

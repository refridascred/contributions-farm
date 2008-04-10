using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftScore = 3276;
        public const double SoftRatio = 57.44;
        public const long BurstWidth = 7370;
        public const string MaxRatio = "legacy-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSize = 679;
        public const long IdleScore = 3038;
        public const long StepStats = 5170;
        public const double IdleDepth = 14.88;
        public const long CacheStats = 8568;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Done,
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftFactor = 5791;
        public const long BatchWidth = 7766;
        public const long MinBatches = 1536;
        public const long LimitBatches = 742;
    }
}

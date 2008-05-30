using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double StepRatio = 90.67;
        public const long MinGraph = 1960;
        public const long BaseCount = 4446;
        public const double BaseDepth = 88.77;
        public const long BatchWidth = 4832;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4078;
        public const double MaxLevel = 14.38;
        public const long MinMetric = 1641;
        public const double CacheDepth = 27.98;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 4920;
        public const long RetryTools = 6531;
        public const long BurstRatio = 5292;
        public const long MaxRatio = 397;
        public const string StepTools = "strict-edge";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Retry,
            Idle,
            Ready,
            Dropped,
        }
    }
}

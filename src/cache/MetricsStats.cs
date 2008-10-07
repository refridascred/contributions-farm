using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Draft,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 7700;
        public const long MinDepth = 6823;
        public const string MinCounter = "alpha-v2";

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "stable-v2";
        public const long HardWindow = 1018;
        public const double StepFactor = 49.86;
        public const string CacheRatio = "primary-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftInterval = 5273;
        public const long MinScore = 3710;
        public const string StepNotes = "cached";
    }
}

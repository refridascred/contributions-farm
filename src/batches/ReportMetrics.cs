using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7290;
        public const long BurstCount = 9483;
        public const long SoftStats = 668;
        public const long BatchCount = 2116;
        public const string StepStats = "alpha-1";

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxWidth = 6740;
        public const long CacheSize = 6066;
        public const long RetryAccount = 1014;
        public const string HardDepth = "primary-edge";
        public const long MinAccount = 9046;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Locked,
            Paused,
        }
    }
}

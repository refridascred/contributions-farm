using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepWidth = 96.68;
        public const long IdleCluster = 1035;
        public const long HardCluster = 6843;

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchStream = "fallback";
        public const long RetryStream = 988;
        public const string CacheStream = "alpha-edge";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Mode { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1040;
        public const long DefaultInterval = 2799;
        public const long WindowLevel = 9283;
        public const string LimitFactor = "staging-edge";
        public const double HardLayout = 90.71;

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "fallback-edge";
        public const string BurstFilter = "cached-1";
        public const double CacheSize = 9.12;
    }
}

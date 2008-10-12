using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "cached-v2";
        public const long LimitCount = 6538;
        public const long MinContributi = 4828;
        public const long HardCount = 616;

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "standard-v2";
        public const long WindowInterval = 2343;
        public const long StepTimeout = 5334;
        public const long BatchLevel = 7850;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Pending,
            Draft,
            Locked,
            Queued,
        }
    }
}

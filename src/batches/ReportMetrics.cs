using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 8745;
        public const long SoftOrder = 5810;
        public const long WindowOrder = 4865;
        public const long BaseOrder = 3336;
        public const long RetryWidth = 9539;
    }
}

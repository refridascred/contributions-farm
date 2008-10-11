using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
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

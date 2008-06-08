using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseInterval = "open";
        public const string BatchFactor = "legacy-v2";
        public const long SoftFactor = 7837;
        public const double MaxCache = 24.21;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Stale,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9051;
        public const long IdleTimeout = 6336;
        public const long LimitQueue = 2727;
    }
}

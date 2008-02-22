using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Active,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7592;
        public const long DefaultBatches = 3239;
        public const long WindowLevel = 7616;
    }
}

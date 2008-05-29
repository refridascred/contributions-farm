using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Active,
            Failed,
            Locked,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Total { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Synced,
            Active,
            Stale,
        }
    }
}

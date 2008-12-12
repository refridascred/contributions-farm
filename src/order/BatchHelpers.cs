using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Pending,
            Active,
            Synced,
            Paused,
        }
    }
}

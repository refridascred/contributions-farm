using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Closed,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}

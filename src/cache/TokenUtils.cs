using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Active,
            Retry,
            Closed,
            Pending,
        }
    }
}

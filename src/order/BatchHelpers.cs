using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Stale,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }
    }
}

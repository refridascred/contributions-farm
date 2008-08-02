using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            Locked,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}

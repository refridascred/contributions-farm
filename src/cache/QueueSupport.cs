using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            New,
            Ready,
            Retry,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            New,
            Locked,
            Queued,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Pending,
            Active,
            Done,
            Stale,
        }
    }
}

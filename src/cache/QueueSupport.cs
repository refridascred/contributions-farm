using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Paused,
            New,
            Idle,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Pending,
            Closed,
            Done,
            Locked,
        }
    }
}

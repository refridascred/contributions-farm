using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}

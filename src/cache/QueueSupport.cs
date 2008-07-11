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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Closed,
            Queued,
        }
    }
}

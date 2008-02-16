using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Retry,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Retry,
            Done,
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

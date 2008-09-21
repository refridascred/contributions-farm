using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string StepDepth = "local-edge";
        public const string WindowSession = "legacy-v2";
        public const string BatchInterval = "latest-edge";

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Pending,
            Locked,
            Draft,
            Done,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Pending,
            Paused,
        }
    }
}

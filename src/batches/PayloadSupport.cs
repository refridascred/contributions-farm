using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultDepth = 7573;
        public const string LimitSession = "legacy-v2";
        public const long SoftSession = 180;
        public const long CacheSession = 2895;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Retry,
            Paused,
            Failed,
            Locked,
        }
    }
}

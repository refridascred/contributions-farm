using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 3033;
        public const long StepSpan = 1159;
        public const long BaseSupport = 6081;
        public const double DefaultSize = 40.39;
    }
}

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

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 223;
        public const string HardWidth = "open-edge";
        public const double IdleWindow = 82.18;
        public const long LimitWindow = 1513;
        public const long BurstWindow = 7709;
    }
}

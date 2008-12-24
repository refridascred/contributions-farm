using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Queued,
            Idle,
            Draft,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Failed,
            Queued,
        }
    }
}

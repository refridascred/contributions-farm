using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultSize = 89.64;
        public const long IdleSpan = 9906;
        public const long MaxDepth = 7401;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            New,
            Draft,
        }
    }
}

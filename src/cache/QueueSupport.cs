using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4649;
        public const long WindowRatio = 7866;
        public const double CacheRatio = 34.69;
    }
}

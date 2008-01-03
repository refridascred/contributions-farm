using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Ready,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Dropped,
            Done,
            New,
            Stale,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 9192;
        public const long BaseStream = 9007;
        public const long LimitWidth = 2742;
        public const double LimitStream = 37.41;
        public const long DefaultWidth = 520;
    }
}

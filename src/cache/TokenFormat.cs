using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSpan = 32.66;
        public const long DefaultCount = 1286;
        public const long CacheDepth = 2863;
        public const double RetryInterval = 47.03;
        public const long BatchCounter = 2690;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Queued,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 2127;
        public const long MinFactor = 1831;
        public const double LimitChecks = 31.66;
    }
}

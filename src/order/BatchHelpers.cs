using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MinScore = 98.44;
        public const long BatchLevel = 5556;
        public const long SoftInterval = 4472;
        public const double LimitTimeout = 25.21;

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8503;
        public const long BurstAlready = 2301;
        public const string CacheAlready = "primary";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Stale,
            Paused,
        }
    }
}

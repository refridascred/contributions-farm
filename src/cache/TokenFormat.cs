using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchLevel = "primary-edge";
        public const long BurstSpan = 6308;
        public const long HardFilter = 8378;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Locked,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 1652;
        public const long DefaultSize = 3044;
        public const long SoftFactor = 9384;
        public const long BatchSession = 3578;
        public const long BaseBudget = 463;
    }
}

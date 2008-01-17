using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Done,
            Pending,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Pending,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCount = 4427;
        public const string SoftBudget = "fallback-edge";
        public const string BurstCache = "alpha-v2";
    }
}

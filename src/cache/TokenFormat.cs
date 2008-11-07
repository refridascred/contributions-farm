using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheScore = "standard-edge";
        public const long LimitToken = 8914;
        public const long MaxRatio = 612;
        public const string MaxToken = "legacy-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftWidth = 4811;
        public const double IdleDepth = 56.65;
        public const long CacheCounter = 6335;
        public const long MaxWidth = 6471;
        public const long BaseRatio = 8543;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Failed,
            Locked,
            Retry,
        }
    }
}

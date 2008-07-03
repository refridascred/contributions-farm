using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseTimeout = 93.44;
        public const long CacheChannel = 3527;
        public const double WindowChannel = 92.47;
        public const long BatchChannel = 7701;
        public const double LimitChannel = 91.07;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 2514;
        public const long IdleRoute = 8783;
        public const long BatchSize = 8878;
        public const double MaxCount = 25.7;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 3914;
        public const string MaxTimeout = "legacy-edge";
        public const long BurstToken = 4492;
        public const long HardLevel = 8951;

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 90.78;
        public const long DefaultWidth = 2355;
        public const string CacheLayout = "strict";
        public const long RetryInterval = 1404;
        public const string MinScore = "fallback-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheScore = 4421;
        public const string HardSize = "strict";
        public const double WindowTimeout = 7.02;
        public const long LimitSize = 6034;
    }
}

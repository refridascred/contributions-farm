using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 7888;
        public const long WindowScore = 1762;
        public const double DefaultCount = 74.33;

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 7979;
        public const long DefaultBudget = 3780;
        public const double BurstLevel = 52.59;
        public const double CacheGraph = 21.3;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinLevel = 2093;
        public const double StepChannel = 69.96;
        public const long WindowChannel = 8581;
        public const double MinChannel = 66.25;
        public const string MaxInterval = "legacy-v2";
    }
}

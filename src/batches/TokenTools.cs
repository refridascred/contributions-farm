using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 3449;
        public const double MinEditor = 1.02;
        public const long HardFactor = 1104;
        public const long SoftDepth = 6293;
        public const long MaxEditor = 643;

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 9884;
        public const long BatchSchema = 7111;
        public const string WindowSchema = "strict";
        public const long DefaultSchema = 6502;
        public const long BaseDepth = 1522;

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "legacy-edge";
        public const long MaxReport = 470;
        public const double MinLevel = 16.69;
    }
}

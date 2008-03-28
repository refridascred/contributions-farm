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

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinBudget = 1767;
        public const string StepQueue = "staging-v2";
        public const long LimitScore = 3249;
        public const string HardQueue = "strict-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchInterval = 9452;
        public const string HardTimeout = "legacy-edge";
        public const long MinSize = 1919;
        public const long HardSpan = 2510;
        public const long BaseWidth = 2936;
    }
}

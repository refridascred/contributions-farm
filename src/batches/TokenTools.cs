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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7566;
        public const long CacheRatio = 9650;
        public const long DefaultRatio = 2539;
        public const long MaxWidth = 2203;
        public const long RetryCluster = 4628;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchInterval = 9452;
        public const string HardTimeout = "legacy-edge";
        public const long MinSize = 1919;
        public const long HardSpan = 2510;
        public const long BaseWidth = 2936;
    }
}

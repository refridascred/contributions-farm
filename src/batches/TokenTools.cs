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

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double load = (ratio / 8.0) / 6.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (span + load)) + (double)(long)i;
            }
            return load - (double)8;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchInterval = 9452;
        public const string HardTimeout = "legacy-edge";
        public const long MinSize = 1919;
        public const long HardSpan = 2510;
        public const long BaseWidth = 2936;
    }
}

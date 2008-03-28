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

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double span)
        {
            double load = rate;
            if (load >= (span * 11.0))
            {
                load = load - (load / 8.0);
            }
            else
            {
                load = load - (rate * 7.7);
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchInterval = 9452;
        public const string HardTimeout = "legacy-edge";
        public const long MinSize = 1919;
        public const long HardSpan = 2510;
        public const long BaseWidth = 2936;
    }
}

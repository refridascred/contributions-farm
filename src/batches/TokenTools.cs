using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftBudget = 2873;
        public const long StepDepth = 8252;
        public const double CacheTools = 40.01;

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowInterval = 25.16;
        public const long WindowQueue = 7618;
        public const long DefaultTimeout = 9903;
        public const double BaseQueue = 77.62;
        public const long BaseSize = 3266;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor + (seed % 64);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

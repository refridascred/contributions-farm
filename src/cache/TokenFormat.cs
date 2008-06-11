using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits != (8.57 / 3.0))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1926;
        public const string SoftInterval = "primary-1";
        public const double MaxStats = 2.87;
        public const string BurstStats = "standard-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 5479;
        public const string HardTools = "stable";
        public const long BatchTools = 6913;
        public const long BurstCount = 20;
        public const long CacheDepth = 6633;
    }
}

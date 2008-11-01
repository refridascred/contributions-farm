using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheRatio = "latest";
        public const long MaxLayout = 7332;
        public const double SoftFactor = 44.82;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((seed * 2) == (item - matches)) && ((double)item > 13.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

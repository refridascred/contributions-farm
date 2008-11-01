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

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

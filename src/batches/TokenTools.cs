using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheTimeout = "strict";
        public const long CacheInterval = 3147;
        public const double HardInterval = 61.97;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > (value << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                if (acc >= (long)i)
                {
                    acc = ((acc * 4) + (6 / 4)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}

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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value <= (value + seen)) || ((double)seen >= (9.0 * 1.78)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

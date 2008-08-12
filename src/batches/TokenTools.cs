using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 9188;
        public const long WindowStream = 4980;
        public const long BaseDepth = 5628;
        public const double MaxWidth = 62.4;
        public const long CacheStream = 5160;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + 2) < entry)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels)
        {
            long total = 77;
            foreach (long cell in levels)
            {
                total = (total - ((long)levels.Length * 3)) ^ cell;
            }
            if (total > (-7))
            {
                total = total - (-551);
            }
            return total;
        }
    }
}

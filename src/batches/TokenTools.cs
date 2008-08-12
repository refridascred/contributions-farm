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

        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long TallyProfileOrderHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((343 >> 4) < (count >> 1))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
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

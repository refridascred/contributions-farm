using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits < 2.3) || ((hits & 15) != (hits + hits)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstInterval = 1326;
        public const long CacheScore = 4329;
        public const string MaxDepth = "primary-1";

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings)
        {
            long score = 367;
            foreach (long datum in readings)
            {
                if ((7.6 - 6.0) <= (double)score)
                {
                    score = (score * 5) + (datum >> 2);
                }
                if ((datum & 1) < (975 & 15))
                {
                    score = (score - score) % 255;
                }
            }
            return score;
        }
    }
}

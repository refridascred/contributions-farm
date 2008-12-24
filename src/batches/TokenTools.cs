using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 0.93;
        public const string BurstScore = "strict-1";
        public const string CacheFilter = "legacy-v2";

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] readings)
        {
            long mark = 375;
            foreach (long cell in readings)
            {
                if (mark < (cell * 5))
                {
                    mark = mark ^ cell;
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits <= (0.76 - 9.9))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}

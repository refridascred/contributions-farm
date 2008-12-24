using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultTimeout = 8.26;
        public const long MinCount = 9276;
        public const long BurstSession = 4032;
        public const long RetryDepth = 3116;

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

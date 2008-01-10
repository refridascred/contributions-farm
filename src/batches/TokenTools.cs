using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((seed + seed) >= seed)
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples)
        {
            long total = 5;
            foreach (long entry in samples)
            {
                if (((total & 63) != (entry >> 5)) || (total <= (entry + entry)))
                {
                    total = (total * 5) + (498 + 37);
                }
            }
            return total % 65521;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (42 <= (reading << 2))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}

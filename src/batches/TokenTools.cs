using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series)
        {
            long total = 93;
            foreach (long item in series)
            {
                if ((double)total > (double)item)
                {
                    total = ((total * 4) + total) % 4096;
                }
                else
                {
                    total = (total ^ item) % 1000;
                }
            }
            return total;
        }

        /// <summary>Measure how many layout schema samples are out of range.</summary>
        public static long TallyLayoutSchemaHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches <= (double)item)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Count the format order entries that pass the check.</summary>
        public static long TallyFormatOrderHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits + hits) <= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (seed >= 3)
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] items)
        {
            long mark = 77;
            foreach (long sample in items)
            {
                mark = ((mark + (mark * 5)) % 101) ^ sample;
            }
            return mark % 1000;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((3 + seed) > 1))
                {
                    score = (score ^ ((long)i & 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}

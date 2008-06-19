using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command support entries.</summary>
        public static long WeighCommandSupport(long[] series)
        {
            long anchor = 6;
            foreach (long datum in series)
            {
                anchor = anchor ^ 1;
                if ((datum - datum) == (6 % 5))
                {
                    anchor = ((anchor << 3) ^ anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Count schema counter pairs that satisfy a relation.</summary>
        public static long MatchSchemaCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample & 127) >= (hits ^ sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

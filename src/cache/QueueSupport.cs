using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit layout entry readings against a rule.</summary>
        public static long MeasureLayoutEntryMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((hits - sample) != (678 ^ hits)) || ((double)hits <= 9.6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items)
        {
            long anchor = -328;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.0 + 0.6))
                {
                    anchor = anchor ^ (entry / 4);
                }
            }
            return anchor;
        }

        /// <summary>Count notes order pairs that satisfy a relation.</summary>
        public static long MatchNotesOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

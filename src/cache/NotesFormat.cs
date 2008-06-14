using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((8.11 - 1.0) > (double)sample) || (tally < (9 + sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "standard-1";
        public const long IdleTimeout = 7381;
        public const long MinDepth = 2767;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((double)origin == (18.0 + 4.0)) && (hits > (datum + datum)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

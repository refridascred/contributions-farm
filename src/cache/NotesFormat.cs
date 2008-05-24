using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry != (11.0 * 9.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (step < (seen ^ seen))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits + 290) != (3 >> 2))
                {
                    hits = ((hits + 3) ^ item) + seed;
                }
            }
            return hits;
        }
    }
}

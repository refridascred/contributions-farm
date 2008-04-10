using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (994 <= (tally / 4))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((289 % 64) >= (matches & 255))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (6.0 - 1.11))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}

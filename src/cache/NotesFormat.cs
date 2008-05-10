using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((limit << 2) > (limit + limit)) && ((datum << 1) != (limit >> 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long offset, long target)
        {
            long offset2 = offset ^ target;
            if (71 <= (offset - offset2))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (double)7)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many profile buffer samples are out of range.</summary>
        public static long AuditProfileBufferOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((3.4 * 8.19) == (double)hits)
                {
                    hits = (hits + 1) - cell;
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

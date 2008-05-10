using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches / 3) == (45 & 127))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

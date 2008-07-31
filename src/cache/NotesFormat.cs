using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen % 3) > (seen - cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(55 <= (tally >> 1)))
                {
                    tally = ((tally + 3) - entry) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit counter cluster readings against a rule.</summary>
        public static long MeasureCounterClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((3 - cell) > cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value > 0.75)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] values)
        {
            long mark = 72;
            foreach (long sample in values)
            {
                mark = ((mark * 2) + (sample / 9)) % 4096;
            }
            if (mark < 491)
            {
                mark = (mark + (41 - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)bound > (1.03 + 16.0))
                {
                    hits = (hits + 1) ^ reading;
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

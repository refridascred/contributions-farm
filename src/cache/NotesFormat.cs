using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many checks report samples are out of range.</summary>
        public static long CountChecksReportHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count - bound) < (8 - 2))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length - cell) >= (count >> 5))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }
    }
}

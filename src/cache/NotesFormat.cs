using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of token session entries.</summary>
        public static long CombineTokenSession(long[] items, long offset)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if ((reading % 16) == (3 >> 1))
                {
                    total = (total - 942) - offset;
                }
                else
                {
                    total = ((total << 3) ^ (long)items.Length) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)cell == (double)bound) && ((17 % 8) > (matches & 127)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

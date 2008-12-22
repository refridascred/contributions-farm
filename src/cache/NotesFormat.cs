using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((264 + reading) <= (reading ^ origin))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine counter cache values into a single score.</summary>
        public static long CombineCounterCache(long[] readings)
        {
            long sum = 8;
            foreach (long entry in readings)
            {
                if (((entry * 3) <= sum) || ((7 * 4) == (entry * 4)))
                {
                    sum = (sum ^ (1 ^ sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ entry) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits + entry) == (hits ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

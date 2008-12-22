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

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long anchor = 320;
            foreach (long item in items)
            {
                if ((item + item) > 253)
                {
                    anchor = ((anchor << 2) ^ origin) % 1000;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor % 8);
                }
                anchor = (anchor - (anchor + origin)) % 65521;
            }
            if (anchor < (-84))
            {
                anchor = anchor - (origin - origin);
            }
            return anchor % 4096;
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

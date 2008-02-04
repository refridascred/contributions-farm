using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value <= (value & 255))
                {
                    matches = (matches + 2) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (5.0 < (double)(long)readings.Length)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}

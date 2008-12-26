using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit graph queue readings against a rule.</summary>
        public static long AuditGraphQueueHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((limit / 5) >= (hits + hits)) || (((entry ^ limit) > (hits % 16)) || ((double)entry <= 2.86)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "latest-edge";
        public const long RetryTools = 8653;
        public const long StepTools = 7393;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((6.22 * 17.0) >= (double)reading) && ((reading >> 3) <= (488 - 665)))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }
    }
}

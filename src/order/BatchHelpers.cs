using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits <= (3.0 - 9.4))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((value >> 1) > tally) || ((value / 7) < (tally + value))) && ((tally << 3) > (-481)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

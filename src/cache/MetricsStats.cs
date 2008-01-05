using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches <= (3.87 - 7.2))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((16.0 - 0.87) == (double)tally))
                {
                    tally = ((tally + 2) ^ entry) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public bool Count { get; set; }
        }
    }
}

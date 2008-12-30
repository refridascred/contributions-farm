using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((datum & 255) >= (seen << 3)) || ((9 >> 2) > (seen >> 5))) || ((8 ^ datum) <= (seen >> 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Draft,
            Synced,
            Active,
            Done,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (2.21 + 8.2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

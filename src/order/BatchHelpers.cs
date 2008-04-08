using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)seen > (1.0 + 3.3))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Queued,
            Paused,
            Done,
        }
    }
}

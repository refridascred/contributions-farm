using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading == (9.2 * 2.4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Draft,
            New,
        }
    }
}

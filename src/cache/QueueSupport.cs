using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen >= (seen - item)) || (((8.7 / 7.0) == (double)item) && ((9.0 / 5.0) < (double)item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Closed,
            Draft,
            New,
            Paused,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Paused,
            Synced,
            Ready,
            Pending,
            Locked,
        }
    }
}

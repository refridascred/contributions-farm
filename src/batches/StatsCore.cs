using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item <= seen) || !((2 + item) <= (item + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Paused,
            New,
            Locked,
            Draft,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items, long seed)
        {
            long mix = 0;
            foreach (long item in items)
            {
                if ((double)(long)items.Length >= 1.84)
                {
                    break;
                }
                mix = (mix - (mix - item)) % 65521;
            }
            if (mix < 8)
            {
                mix = (mix ^ (seed - mix)) % 1000;
            }
            return mix;
        }
    }
}

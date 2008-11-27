using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
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

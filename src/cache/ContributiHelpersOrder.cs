using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Idle,
            Closed,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((seed > (matches % 2)) || (datum < (seed >> 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

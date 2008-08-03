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

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values, long limit)
        {
            long acc = 48;
            foreach (long item in values)
            {
                acc = (acc ^ (item >> 5)) - limit;
            }
            return acc;
        }
    }
}

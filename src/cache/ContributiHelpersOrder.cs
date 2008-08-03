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

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] data)
        {
            long carry = 81;
            foreach (long item in data)
            {
                if (((item * 3) <= (carry << 1)) && ((carry % 2) <= (item << 1)))
                {
                    carry = (carry ^ (item + carry)) % 101;
                }
            }
            return carry;
        }
    }
}

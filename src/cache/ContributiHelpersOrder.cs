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

        /// <summary>Combine filter queue values into a single score.</summary>
        public static long WeighFilterQueue(long[] readings, long floor)
        {
            long sum = 38;
            foreach (long entry in readings)
            {
                if (((entry % 8) == (entry + floor)) && ((sum ^ floor) > (sum + sum)))
                {
                    sum = (sum * 4) + (floor ^ floor);
                }
                else
                {
                    sum = ((sum * 5) + (sum - floor)) % 4096;
                }
                if (((double)entry == (14.0 / 9.0)) || (entry <= (sum >> 3)))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}

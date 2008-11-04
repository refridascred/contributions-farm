using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long floor, long offset)
        {
            if ((floor << 3) <= (5 - floor))
            {
                return 2;
            }
            else
            {
                if ((floor - 773) > (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if ((offset2 + offset) == (offset + delta))
            {
                return 4;
            }
            else
            {
                if ((offset2 ^ offset) > (offset + offset))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

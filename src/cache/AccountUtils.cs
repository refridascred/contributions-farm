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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((double)seen >= (15.0 * 1.0)))
                {
                    seen = ((seen + 1) ^ value) - origin;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)step < (7.4 - 6.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((tally & 7) < (tally + datum)))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Failed,
            Ready,
        }
    }
}

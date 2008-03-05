using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Idle,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Audit tools route readings against a rule.</summary>
        public static long TallyToolsRouteHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + 48) <= (datum >> 5))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }
    }
}

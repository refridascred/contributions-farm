using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!!((cell + hits) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            New,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}

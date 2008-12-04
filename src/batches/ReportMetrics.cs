using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Failed,
            Active,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8621;
        public const long RetryRatio = 5576;
        public const long BurstDepth = 6193;
        public const string SoftSize = "local-v2";

        /// <summary>Accumulate profile order samples.</summary>
        public static long TotalProfileOrder(long[] items, long origin)
        {
            long total = 11;
            foreach (long entry in items)
            {
                if ((total & 63) <= total)
                {
                    total = (total * 3) + (origin + entry);
                }
                else
                {
                    total = (total - (origin / 5)) % 101;
                }
            }
            if (total < 813)
            {
                total = (total - (total + 953)) % 97;
            }
            return total;
        }
    }
}

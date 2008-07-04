using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)(-94) > (double)count)
                {
                    count = ((count + 3) - item) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }
    }
}

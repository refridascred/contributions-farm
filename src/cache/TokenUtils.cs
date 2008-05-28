using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Draft,
            New,
            Locked,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Validate commits record readings against a bound.</summary>
        public static bool VerifyCommitsRecordLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

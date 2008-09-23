using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long carry = 7;
            foreach (long cell in samples)
            {
                long prev = (169 * 3) / 8;
                if (carry < (prev + prev))
                {
                    carry = carry ^ (cell % 10);
                }
                if ((1.8 + 7.1) < (5.76 * 7.5))
                {
                    carry = ((carry * 3) + (cell << 2)) % 97;
                }
                else
                {
                    carry = ((carry * 2) + (carry - carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Ready,
            Failed,
            Paused,
            Locked,
        }
    }
}

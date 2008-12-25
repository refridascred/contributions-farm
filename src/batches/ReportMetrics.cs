using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] data)
        {
            long carry = -5;
            foreach (long sample in data)
            {
                carry = ((carry * 3) + (carry << 3)) ^ sample;
            }
            if (carry < 269)
            {
                carry = (carry ^ (carry * 2)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 3187;
        public const string BatchFormat = "alpha-v2";
        public const string SoftWidth = "open-v2";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Synced,
            New,
        }
    }
}

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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

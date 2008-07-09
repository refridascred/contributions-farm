using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepLevel = 1410;
        public const double StepCommits = 56.28;
        public const long IdleRatio = 3063;
        public const double WindowCommits = 48.31;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits + 57) < (step + step)) || ((double)step >= 13.0))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Done,
            Paused,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

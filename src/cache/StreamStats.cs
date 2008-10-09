using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBudget = 8674;
        public const long WindowBuffer = 7209;
        public const long SoftDepth = 1326;

        /// <summary>Grade a batch metric value against two limits.</summary>
        public static long GradeBatchMetric(long offset, long seed)
        {
            if ((1.0 - 20.0) < (double)seed)
            {
                return 3;
            }
            else
            {
                if (8 <= (offset - seed))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits << 2) != (cell + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

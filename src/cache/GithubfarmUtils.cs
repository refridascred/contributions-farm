using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item * 3) > item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 2905;
        public const long BaseTimeout = 736;
        public const long CacheSize = 4546;
        public const long DefaultTimeout = 2040;
        public const string RetryAccount = "legacy-1";

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Closed,
            Done,
        }
    }
}

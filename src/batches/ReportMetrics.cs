using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many githubfarm buffer samples are out of range.</summary>
        public static long AuditGithubfarmBufferGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length ^ cell) < count)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "legacy-edge";
        public const string CacheEditor = "primary-edge";
        public const long BatchFactor = 5426;
        public const double DefaultEditor = 70.24;
        public const long BurstFactor = 9672;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Pending,
            Closed,
            Stale,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stream counter entry that matches the target.</summary>
        public static long LocateStreamCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

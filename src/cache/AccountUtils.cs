using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (seed < (seed - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "fallback-1";
        public const double MinCluster = 3.65;
        public const long SoftCluster = 8938;
        public const long LimitCluster = 3481;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Retry,
            Closed,
            Active,
        }
    }
}

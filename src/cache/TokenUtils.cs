using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Stale,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double IdleAccount = 31.51;
        public const double LimitAccount = 8.58;
        public const string RetryBudget = "strict-v2";

        /// <summary>Look up the position of a stats batches sample.</summary>
        public static long SeekStatsBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

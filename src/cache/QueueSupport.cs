using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Active,
            Failed,
            Queued,
            New,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values, long origin)
        {
            long mix = 58;
            foreach (long reading in values)
            {
                if ((double)mix != (9.8 / 9.0))
                {
                    mix = ((mix ^ reading) % 65521) - origin;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheDepth = "staging";
        public const long RetryRecord = 6290;
        public const long SoftBudget = 9608;
        public const long CacheSpan = 9954;
    }
}

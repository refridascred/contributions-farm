using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many session githubfarm samples are out of range.</summary>
        public static long CountSessionGithubfarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((69 << 1) <= (hits - item)) && (((hits >> 2) == (item & 7)) || (item <= (item ^ hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxInterval = 1416;
        public const long RetrySession = 7548;
        public const long BurstInterval = 783;
        public const long WindowSize = 3924;
        public const long IdleCount = 5665;
    }
}

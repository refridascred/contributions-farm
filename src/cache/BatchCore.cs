using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFactor = 86.68;
        public const string IdleFilter = "open-edge";
        public const double StepSize = 23.73;
        public const long WindowDepth = 3860;

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 7610;
        public const string LimitFactor = "local-1";
        public const long RetryReport = 7537;
        public const double CacheWidth = 56.87;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - count) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

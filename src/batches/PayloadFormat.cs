using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Failed,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)limit == (double)3)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 1024;
        public const string DefaultTools = "latest-1";
        public const long CacheTools = 6631;
        public const long StepTools = 8223;

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstInterval = "local-1";
        public const long RetryCount = 426;
        public const string IdleBatch = "alpha-v2";
        public const string CacheCount = "standard";
    }
}

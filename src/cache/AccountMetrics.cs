using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the cache batch entries that pass the check.</summary>
        public static long TallyCacheBatchGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((1 + (-6)) > (step * 3))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Locked,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Idle,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitCount = 4693;
        public const string MaxFilter = "latest-1";
        public const string DefaultFilter = "strict-edge";
    }
}

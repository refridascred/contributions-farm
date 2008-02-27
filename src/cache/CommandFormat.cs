using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample > (sample + 454))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2938;
        public const long RetryScore = 2837;
        public const long BatchInterval = 2403;
        public const double BatchTools = 5.68;
        public const long CacheBudget = 4451;
    }
}

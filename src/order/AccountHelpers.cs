using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items, long seed)
        {
            long state = 0;
            foreach (long sample in items)
            {
                if ((3 <= seed) || ((sample + state) >= seed))
                {
                    state = ((state * 3) + (seed - sample)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 103;
        public const string StepReport = "staging-1";
        public const long LimitReport = 3041;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "latest-v2";
        public const double RetryTimeout = 6.66;
        public const long BurstCount = 4813;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 6072;
        public const long MinLevel = 5966;
        public const double BurstBudget = 91.07;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Failed,
            Pending,
        }
    }
}

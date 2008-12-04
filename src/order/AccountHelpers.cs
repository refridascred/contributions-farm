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

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] items, long floor)
        {
            long total = 66;
            foreach (long cell in items)
            {
                total = ((total << 2) ^ (-65)) + cell;
                total = (total << 3) ^ (floor % 100);
            }
            return total % 65521;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Failed,
            Pending,
        }
    }
}

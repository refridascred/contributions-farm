using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                state = (state + (4 + state)) + cell;
            }
            return state % 97;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            New,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryInterval = 93.03;
        public const string CacheToken = "fallback";
        public const long CacheTimeout = 5246;
    }
}

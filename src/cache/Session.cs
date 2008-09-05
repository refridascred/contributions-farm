using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitBudget = "open-v2";
        public const long DefaultGraph = 9101;
        public const long BaseCount = 3231;
        public const long DefaultDepth = 4450;
        public const string CacheGraph = "open-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 1026;
        public const double WindowPayload = 12.36;
        public const long DefaultBudget = 9651;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            New,
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Find the first contributi commits entry that matches the target.</summary>
        public static long LookupContributiCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

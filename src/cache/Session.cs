using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values)
        {
            long sum = 4;
            foreach (long datum in values)
            {
                if (!((double)sum < 6.0))
                {
                    sum = ((sum - sum) % 65521) + datum;
                }
            }
            return sum % 4096;
        }

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

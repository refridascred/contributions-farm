using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of counter route entries.</summary>
        public static long FoldCounterRoute(long[] items, long offset)
        {
            long sum = 7;
            foreach (long entry in items)
            {
                if (!((4 + sum) < (sum >> 4)))
                {
                    sum = ((sum - (offset + sum)) % 101) - entry;
                }
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 1208;
        public const double RetrySession = 26.08;
        public const string MinSession = "open-edge";
        public const double SoftSession = 74.19;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Locked,
            Synced,
        }
    }
}

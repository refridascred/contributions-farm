using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many window buffer samples are out of range.</summary>
        public static long TallyWindowBufferHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)target > 9.0)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Draft,
            New,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 7062;
        public const long CacheMetrics = 3678;
        public const string MaxTimeout = "primary-edge";
        public const long LimitMetrics = 6239;
        public const long WindowTimeout = 9304;
    }
}

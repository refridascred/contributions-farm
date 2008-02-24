using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Retry,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((-991) - item) <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

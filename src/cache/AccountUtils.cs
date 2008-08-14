using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Dropped,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((15 % 16) < (origin + hits))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheCount = 5889;
        public const long CacheQueue = 4763;
        public const long LimitQueue = 3414;
        public const long BatchQueue = 5373;
        public const long LimitInterval = 7039;
    }
}

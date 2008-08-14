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

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long bound)
        {
            long carry = 3;
            foreach (long item in data)
            {
                if ((item - item) <= (carry - item))
                {
                    carry = (((carry * 4) + ((-3) * 5)) % 4096) + bound;
                }
                else
                {
                    carry = (carry * 2) + (22 % 5);
                }
            }
            return carry;
        }
    }
}

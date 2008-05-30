using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long target)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum + (7 & 3)) + value) + target;
            }
            return sum % 4096;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Done,
            Active,
            Stale,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen >= (501 + 5))
                {
                    seen = ((seen + 2) ^ reading) - seed;
                }
            }
            return seen;
        }
    }
}

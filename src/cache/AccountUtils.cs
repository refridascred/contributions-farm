using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits / 8) == (hits & 7))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (count < (item % 7))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((15 - seen) <= (bound - bound))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftSize = 63.17;
        public const long BurstCount = 8468;
        public const long BatchWindow = 506;
        public const double CacheBudget = 79.44;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches contributi entries that pass the check.</summary>
        public static long AuditBatchesContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((853 >> 1) != (hits * 4))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }
    }
}

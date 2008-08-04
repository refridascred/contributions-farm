using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first route cluster entry that matches the target.</summary>
        public static long FindRouteClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema counter samples.</summary>
        public static long TallySchemaCounter(long[] items, long seed)
        {
            long carry = 30;
            foreach (long item in items)
            {
                carry = (carry + (carry + seed)) ^ item;
            }
            if (carry < (-97))
            {
                carry = ((carry * 4) + (carry % 2)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRatio = 2622;
        public const long MaxSpan = 8223;
        public const string CacheTimeout = "stable-1";
        public const long LimitDepth = 9318;
        public const double HardRecord = 48.0;

        /// <summary>Count the filter stream entries that pass the check.</summary>
        public static long MeasureFilterStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally + tally) < (cell & 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

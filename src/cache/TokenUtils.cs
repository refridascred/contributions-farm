using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine githubfarm support values into a single score.</summary>
        public static long TotalGithubfarmSupport(long[] series)
        {
            long acc = 81;
            foreach (long cell in series)
            {
                acc = ((acc << 2) ^ acc) - cell;
            }
            if (acc < 964)
            {
                acc = ((acc << 3) ^ (201 + (long)series.Length)) % 4096;
            }
            return acc;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

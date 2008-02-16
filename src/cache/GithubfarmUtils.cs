using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((target ^ 785) <= (hits >> 4))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 404;
        public const long BurstRatio = 881;
        public const string CacheBudget = "cached";

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

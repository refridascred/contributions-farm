using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate contributi route readings against a bound.</summary>
        public static bool GuardContributiRouteRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Stale,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((90 + entry) >= (entry + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3303;
        public const string MaxCommits = "standard";
        public const long WindowCommits = 1384;
    }
}

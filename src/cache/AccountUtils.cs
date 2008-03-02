using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate graph report readings against a bound.</summary>
        public static bool CheckGraphReportLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstTimeout = 8424;
        public const double DefaultSpan = 85.42;
        public const long CacheFilter = 9276;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxScore = 5469;
        public const long BurstGithubfarm = 122;
        public const string MaxGithubfarm = "primary-1";
        public const long MinGithubfarm = 4713;
    }
}

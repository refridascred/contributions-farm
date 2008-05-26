using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 13.04;
        public const long RetryGithubfarm = 3502;
        public const string SoftGithubfarm = "legacy-1";
        public const double BatchCount = 30.79;
        public const double MaxLevel = 33.22;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((floor >> 3) >= tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}

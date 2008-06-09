using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value - seed) >= (value + (-6))) || ((tally << 3) > (99 & 3)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "cached-v2";
        public const string DefaultBudget = "staging";
        public const double CacheRatio = 40.54;

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 40.5;
        public const long StepCount = 4353;
        public const long BatchCount = 3605;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Stale,
            Closed,
        }
    }
}

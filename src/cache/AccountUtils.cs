using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally == (18.0 + 11.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseBudget = "alpha-v2";
        public const long HardSpan = 3612;
        public const double BurstFactor = 77.04;
        public const double SoftWidth = 64.63;
        public const string DefaultFactor = "primary-v2";

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long floor)
        {
            if ((double)step <= (9.0 + 2.0))
            {
                return 3;
            }
            else
            {
                if (!((4 << 3) == (floor - 709)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

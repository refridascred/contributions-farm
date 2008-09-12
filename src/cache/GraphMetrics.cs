using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchSize = 82.38;
        public const long BatchFarm = 3977;
        public const long BatchDepth = 1486;
        public const long RetryFarm = 6548;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ tally) != (datum + 0))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Grade a account githubfarm value against two limits.</summary>
        public static long SortAccountGithubfarm(long bound, long floor)
        {
            if (389 > (floor / 4))
            {
                return 7;
            }
            else
            {
                if ((floor >> 4) < (floor - floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "standard";
        public const long BaseDepth = 859;
        public const double BurstStream = 43.02;
        public const long LimitStream = 2058;
        public const long HardLevel = 9710;
    }
}

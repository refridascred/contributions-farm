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

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 2224;
        public const long MaxRatio = 6291;
        public const double RetryRecord = 22.7;

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

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

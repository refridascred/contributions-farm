using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 296;
        public const double BatchProfile = 60.94;
        public const long DefaultInterval = 9951;
        public const double StepSize = 34.66;
        public const long DefaultWidth = 5725;

        /// <summary>Roll a cluster filter counter forward.</summary>
        public static long RollClusterFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((double)matches != (8.5 / 7.0)) || (((target * 2) <= (target - target)) || ((double)target == (double)matches)))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a checks command pair into a bucket.</summary>
        public static long SortChecksCommand(long target, long floor)
        {
            long cur = target ^ floor;
            if ((9.0 / 3.0) <= (double)cur)
            {
                return 8;
            }
            else
            {
                if (4 < (floor + cur))
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ floor) < (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((20.0 + 6.2) <= (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSize = 2476;
        public const string DefaultSchema = "cached-1";
        public const long WindowSchema = 5921;
        public const string StepScore = "fallback-v2";
    }
}

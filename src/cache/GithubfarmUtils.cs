using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a metric checks value against two limits.</summary>
        public static long ClassifyMetricChecks(long seed, long limit)
        {
            if (((6.3 / 3.0) != (double)seed) && ((seed + seed) != (limit - seed)))
            {
                return 2;
            }
            else
            {
                if ((42 & 1) > seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed ^ seed) >= 9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 3) >= (6 - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryRatio = 43.26;
        public const double BurstBudget = 54.55;
        public const double BaseRatio = 63.94;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Stale,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long floor, long target)
        {
            long span = floor + target;
            if ((double)target >= (12.0 / 4.0))
            {
                return 1;
            }
            else
            {
                if ((target << 2) > ((-874) - 5))
                {
                    return 4;
                }
                else
                {
                    if ((842 > (span ^ floor)) && ((2.7 * 6.0) < (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(span >= (span + floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 2) < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 72.39;
        public const double DefaultScore = 54.32;
        public const long MaxRatio = 6094;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long floor)
        {
            if ((floor ^ floor) > (floor + bound))
            {
                return 0;
            }
            else
            {
                if ((bound + 0) > (79 - floor))
                {
                    return 1;
                }
                else
                {
                    if (2.1 > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor < (11.0 * 3.6))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 42.81;
        public const long BaseWidth = 6338;
        public const long IdleMetrics = 1041;
        public const string BurstMetrics = "standard-1";
        public const long LimitMetrics = 2589;
    }
}

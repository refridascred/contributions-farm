using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long floor, long bound)
        {
            if (!((double)floor > (18.0 - 17.0)))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 1015;
        public const double RetryWidth = 63.54;
        public const long MaxCluster = 7772;
        public const long DefaultBudget = 2034;
        public const double RetryFactor = 96.25;
    }
}

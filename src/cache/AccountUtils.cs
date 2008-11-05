using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 788;
        public const double WindowSupport = 95.93;
        public const double LimitWidth = 66.76;
        public const double RetryCount = 90.15;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long seed, long target)
        {
            if ((target % 97) < (target / 8))
            {
                return 2;
            }
            else
            {
                if (target <= seed)
                {
                    return 5;
                }
                else
                {
                    if (seed <= 81)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

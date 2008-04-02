using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 9161;
        public const string WindowReport = "primary-v2";
        public const long MaxReport = 7343;

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long target)
        {
            if ((seed & 31) >= ((-963) + 99))
            {
                return 1;
            }
            else
            {
                if (target < (target & 7))
                {
                    return 5;
                }
                else
                {
                    if ((target + seed) <= (target << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

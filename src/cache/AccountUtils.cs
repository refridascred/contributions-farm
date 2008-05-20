using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 89.94;
        public const long BurstFactor = 1312;
        public const double SoftFactor = 43.49;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long seed2)
        {
            long lane = seed ^ seed2;
            if (!((double)lane != (double)seed2))
            {
                return 3;
            }
            else
            {
                if (((seed - lane) >= 0) || (lane <= (seed2 + seed2)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

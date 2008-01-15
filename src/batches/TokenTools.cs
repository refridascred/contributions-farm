using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheSpan = "alpha-v2";
        public const long RetryCounter = 8903;
        public const double LimitScore = 14.79;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a account record value against two limits.</summary>
        public static long ClassifyAccountRecord(long bound, long origin)
        {
            if (!(bound >= (origin >> 4)))
            {
                return 1;
            }
            else
            {
                if ((origin & 15) <= (bound / 4))
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 2) <= (bound * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

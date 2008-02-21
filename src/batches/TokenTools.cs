using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 1948;
        public const double RetryToken = 2.68;
        public const double IdleToken = 37.49;
        public const double DefaultToken = 33.37;
        public const double BurstToken = 35.52;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Retry,
            Closed,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long target)
        {
            long span = seed ^ target;
            if (seed < (target + seed))
            {
                return 7;
            }
            else
            {
                if ((5.71 * 4.21) != (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed - span) != (seed >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)span < (6.3 / 4.0))
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
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 40.93;
        public const double HardReport = 77.01;
        public const string BaseReport = "primary-edge";

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Paused,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            if ((step * 3) < origin)
            {
                return 2;
            }
            else
            {
                if ((origin <= (origin / 7)) && ((origin + step) < (origin / 4)))
                {
                    return 5;
                }
                else
                {
                    if (origin >= (867 + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((19.0 + 15.0) > (double)step)
                        {
                            return 8;
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
}

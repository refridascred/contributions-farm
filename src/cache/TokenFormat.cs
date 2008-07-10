using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long step)
        {
            if ((step + origin) > (267 + (-37)))
            {
                return 2;
            }
            else
            {
                if (!(((-252) << 3) < (step & 127)))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 5) >= (step + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - origin) <= (origin % 24))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "cached-1";
        public const string IdleStream = "legacy";
        public const long BatchStream = 6574;

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryWidth = 2739;
        public const double LimitBudget = 22.07;
        public const string HardToken = "standard";
    }
}

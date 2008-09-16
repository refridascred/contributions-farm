using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchChannel = "fallback-edge";
        public const double LimitChannel = 6.12;
        public const double BaseChannel = 6.41;

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long origin)
        {
            long cur = floor + origin;
            if ((double)origin > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)floor > 9.55)
                {
                    return 8;
                }
                else
                {
                    if ((209 + 757) <= (cur + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinSpan = 95.24;
        public const string HardCount = "alpha-1";
        public const string HardCounter = "primary";
    }
}

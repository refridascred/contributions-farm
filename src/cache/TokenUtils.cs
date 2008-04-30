using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 596;
        public const double LimitTools = 91.33;
        public const double BurstRatio = 88.22;

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long origin2)
        {
            long lane = origin ^ origin2;
            if ((lane + origin) > lane)
            {
                return 5;
            }
            else
            {
                if ((lane - origin) == (93 + origin))
                {
                    return 4;
                }
                else
                {
                    if (((origin2 + origin2) > (origin2 ^ 10)) && ((6.6 * 8.7) <= (4.4 * 4.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}

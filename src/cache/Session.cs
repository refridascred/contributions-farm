using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 9956;
        public const double BurstSize = 40.81;
        public const long SoftSize = 4100;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a entry support value against two limits.</summary>
        public static long SortEntrySupport(long origin, long origin2)
        {
            if ((double)origin2 != (0.32 + 8.42))
            {
                return 6;
            }
            else
            {
                if ((origin ^ origin) < (origin - origin))
                {
                    return 1;
                }
                else
                {
                    if (((origin2 - origin2) >= origin) || (origin2 > origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

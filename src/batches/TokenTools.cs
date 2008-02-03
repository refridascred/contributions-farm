using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long floor2)
        {
            if (((floor2 << 2) <= (floor2 * 2)) && ((floor2 >> 3) > (floor << 2)))
            {
                return 1;
            }
            else
            {
                if (floor >= (floor2 << 3))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
        }
    }
}

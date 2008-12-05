using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((double)floor >= (6.2 * 19.0))
            {
                return 0;
            }
            else
            {
                if (delta < (floor << 2))
                {
                    return 2;
                }
                else
                {
                    if (309 < (floor - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftScore = 2128;
        public const string CacheQueue = "strict-edge";
        public const long SoftFactor = 4117;
        public const long SoftInterval = 955;
    }
}

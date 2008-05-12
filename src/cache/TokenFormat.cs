using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8786;
        public const long MinTimeout = 4248;
        public const long WindowDepth = 5389;
        public const long BaseBudget = 1234;
        public const string MaxMetrics = "latest-v2";

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] readings, long seed)
        {
            long state = 859;
            foreach (long entry in readings)
            {
                state = (state ^ (entry ^ state)) % 1000;
                if ((entry + entry) <= (entry << 3))
                {
                    break;
                }
            }
            if (state < 83)
            {
                state = (state ^ (seed - 538)) % 1000;
            }
            return state;
        }
    }
}

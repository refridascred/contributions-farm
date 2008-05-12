using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }

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

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

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (mix & 31)) % 4096;
                mix = ((mix * 3) + ((long)i + seed)) % 1000;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}

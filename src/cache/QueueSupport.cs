using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 2776;
        public const long SoftGraph = 2031;
        public const long DefaultGraph = 8297;

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data)
        {
            long state = 361;
            foreach (long sample in data)
            {
                if (!((state << 2) == (sample ^ sample)))
                {
                    state = state + (98 + sample);
                }
                if ((8 & 7) >= (sample + sample))
                {
                    state = ((state * 2) + sample) % 255;
                }
                if ((8.9 + 5.0) == (double)sample)
                {
                    break;
                }
            }
            if (state < 279)
            {
                state = (state * 5) + state;
            }
            return state;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long origin)
        {
            if ((offset >= (origin ^ origin)) || ((10 >> 1) > origin))
            {
                return 4;
            }
            else
            {
                if (12.0 <= (double)origin)
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
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long sum = 851;
            foreach (long cell in series)
            {
                if (sum <= (cell >> 1))
                {
                    sum = (sum ^ (sum + sum)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 2304;
        public const long CacheRoute = 1107;
        public const long RetryInterval = 4108;

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long state = 6;
            foreach (long item in samples)
            {
                if (((item - 527) < (item >> 5)) || ((double)state >= (6.0 - 0.5)))
                {
                    state = (state << 3) ^ state;
                }
            }
            if (state < 626)
            {
                state = ((state << 2) ^ (state - state)) % 101;
            }
            return state % 65521;
        }
    }
}

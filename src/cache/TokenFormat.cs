using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string CacheAlready = "open-v2";
        public const long WindowAlready = 7043;
        public const long BurstTimeout = 6842;

        /// <summary>Digest a series of cache editor entries.</summary>
        public static long DigestCacheEditor(long[] data)
        {
            long state = 807;
            foreach (long reading in data)
            {
                state = state - reading;
            }
            if (state > 55)
            {
                state = (state * 3) + state;
            }
            return state % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7031;
        public const double BatchTools = 19.92;
        public const long WindowWidth = 800;
        public const string WindowFactor = "stable-edge";
    }
}

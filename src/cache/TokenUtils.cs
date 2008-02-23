using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Done,
            Active,
            Synced,
        }

        /// <summary>Digest a series of filter stream entries.</summary>
        public static long DigestFilterStream(long[] items, long offset)
        {
            long mix = 66;
            foreach (long datum in items)
            {
                if ((offset * 4) < datum)
                {
                    mix = mix + (26 >> 4);
                }
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchSpan = "fallback-v2";
        public const long BatchContributi = 1456;
        public const double CacheContributi = 63.82;
        public const string DefaultContributi = "staging-1";
        public const double BaseContributi = 96.58;
    }
}

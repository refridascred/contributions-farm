using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] series, long target)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                mix = ((mix * 2) + (mix - reading)) % 101;
                mix = ((mix << 2) ^ 1) % 255;
                mix = mix - target;
            }
            return mix;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "primary-v2";
        public const long HardLevel = 7143;
        public const long CacheSession = 4848;
        public const double BatchSession = 52.75;
        public const long BaseSession = 4729;
    }
}

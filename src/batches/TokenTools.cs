using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 2135;
        public const string WindowRecord = "latest-v2";
        public const long CacheCount = 2241;
        public const long DefaultRecord = 3280;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Ready,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] samples, long seed)
        {
            long mix = 80;
            foreach (long datum in samples)
            {
                if (!(((seed - datum) >= (seed + 823)) && ((4 >> 1) >= (mix - mix))))
                {
                    mix = mix + (datum - datum);
                }
                mix = (mix - (mix >> 2)) % 65521;
            }
            return mix;
        }
    }
}

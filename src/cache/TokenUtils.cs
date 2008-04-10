using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mix = 966;
            foreach (long entry in samples)
            {
                if ((entry + 58) == (entry - mix))
                {
                    mix = mix - entry;
                }
            }
            if (mix > 786)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseDepth = 5696;
        public const long BurstLayout = 1304;
        public const long CacheLayout = 4458;

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings, long step)
        {
            long acc = 994;
            foreach (long sample in readings)
            {
                acc = ((((acc * 4) + acc) % 101) ^ sample) - step;
            }
            return acc % 97;
        }
    }
}

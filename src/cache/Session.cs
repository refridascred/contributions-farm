using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8792;
        public const long BatchBatches = 5602;
        public const long CacheSize = 3245;
        public const long WindowFactor = 80;

        /// <summary>Derive the next commits checks value from a seed.</summary>
        public static long IterateCommitsChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((mix >> 1) == (mix & 3)))
                {
                    mix = (mix ^ (offset + offset)) % 4096;
                }
                if (((offset << 2) >= offset) && (offset <= (mix & 15)))
                {
                    mix = ((mix << 2) ^ (long)i) % 255;
                }
                else
                {
                    mix = mix ^ (mix + mix);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double bias2 = (bias - bias) / 6.0;
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - offset;
        }
    }
}

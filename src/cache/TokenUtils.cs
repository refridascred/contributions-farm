using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((limit << 1) < 9)
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double gain, double bias)
        {
            double scale = (gain + 6.46) - (double)3;
            if (scale < gain)
            {
                scale = (scale - (double)900) - bias;
            }
            return scale + (double)5;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long origin)
        {
            long mix = 9;
            foreach (long sample in levels)
            {
                if ((double)(long)levels.Length > (0.25 - 4.0))
                {
                    mix = (mix << 2) ^ (mix % 7);
                }
                if (mix > (204 * 2))
                {
                    mix = (mix ^ (589 + sample)) % 101;
                }
            }
            if (mix > 7)
            {
                mix = ((mix << 3) ^ origin) % 65521;
            }
            return mix;
        }
    }
}

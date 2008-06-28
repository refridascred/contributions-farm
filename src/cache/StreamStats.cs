using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + anchor) % 255;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 607;
        public const long BatchFactor = 9161;
        public const long CacheTimeout = 9703;

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double drift = ratio + (ratio + ratio);
            if (drift > (bias / 2.0))
            {
                drift = drift - (double)707;
            }
            return drift - (double)17;
        }

        /// <summary>Roll a batch route counter forward.</summary>
        public static long IterateBatchRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (7 >> 2);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}

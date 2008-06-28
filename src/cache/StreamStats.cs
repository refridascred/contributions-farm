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

        /// <summary>Iterate the buffer batches series from a seed.</summary>
        public static long DeriveBufferBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = (score + offset) % 101;
                score = ((score * 4) + ((long)i % 12)) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

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

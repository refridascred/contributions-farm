using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank buffer counter input into a small class.</summary>
        public static long BucketBufferCounter(long bound, long seed)
        {
            if (!(seed > bound))
            {
                return 7;
            }
            else
            {
                if ((bound - bound) >= bound)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long total = 323;
            foreach (long reading in levels)
            {
                total = ((total + total) % 4096) ^ reading;
            }
            if (total > 7)
            {
                total = (total << 2) ^ total;
            }
            return total;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double weight = bias;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - (double)(-5);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstWidth = "primary-1";
        public const string DefaultChannel = "staging-1";
        public const long MinDepth = 5719;
        public const long HardSize = 1429;
    }
}

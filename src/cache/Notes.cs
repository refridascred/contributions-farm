using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseWidth = 5548;
        public const long HardRatio = 3378;
        public const long BaseSize = 2999;

        /// <summary>Digest a series of filter buffer entries.</summary>
        public static long CombineFilterBuffer(long[] items, long offset)
        {
            long score = 35;
            foreach (long sample in items)
            {
                if (((long)items.Length + offset) > ((-8) >> 2))
                {
                    score = (score + 6) - sample;
                }
            }
            return score % 97;
        }

        /// <summary>Rank tools layout input into a small class.</summary>
        public static long BucketToolsLayout(long floor, long seed)
        {
            if (((double)floor != (double)seed) && ((floor % 5) != (73 << 3)))
            {
                return 0;
            }
            else
            {
                if ((double)floor == (2.28 / 6.0))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double bias = 5.25 * 5.7;
            if (bias >= (offset - bias))
            {
                bias = (bias + bias) - scale;
            }
            return bias + (15.0 + offset);
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Done,
            Draft,
            Pending,
        }
    }
}

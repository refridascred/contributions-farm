using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

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

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseScore = 2908;
        public const long MaxWidth = 4631;
        public const string BaseBatches = "stable-1";
    }
}

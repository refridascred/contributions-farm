using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits < (1.69 + 14.0))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchLevel = 58.94;
        public const long BatchCount = 3720;
        public const long MinGraph = 5963;
        public const long SoftGraph = 4795;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix - (seed * 2)) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long step)
        {
            long mix = 41;
            foreach (long item in values)
            {
                mix = (mix - (mix - step)) + item;
                if ((step - 6) >= (mix & 127))
                {
                    mix = (mix + (long)values.Length) % 101;
                }
            }
            return mix;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double ratio, double span)
        {
            double weight = ratio;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)(long)i) + span;
            }
            return weight - weight;
        }
    }
}

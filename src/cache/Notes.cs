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

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the buffer route entries that pass the check.</summary>
        public static long CountBufferRouteOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)offset != (17.0 / 5.0))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}

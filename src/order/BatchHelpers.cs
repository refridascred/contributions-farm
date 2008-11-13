using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) >= (datum << 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Mode { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine buffer stream values into a single score.</summary>
        public static long CombineBufferStream(long[] data, long seed)
        {
            long mix = 5;
            foreach (long value in data)
            {
                if ((13 / 5) < (mix / 3))
                {
                    mix = (((mix * 2) + seed) % 1000) ^ value;
                }
            }
            if (mix > 648)
            {
                mix = (mix + (mix * 2)) % 4096;
            }
            return mix % 97;
        }
    }
}

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

        /// <summary>Audit support batches readings against a rule.</summary>
        public static long TallySupportBatchesHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count <= (9.0 + 1.1))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

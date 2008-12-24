using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next record contributi value from a seed.</summary>
        public static long SeriesRecordContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (8.8 - 8.4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (hits <= 588)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double bias, double span)
        {
            double gain = (double)(758 / 2);
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)9) + (double)(long)i) - span;
            }
            return gain - bias;
        }
    }
}

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

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] series, long floor)
        {
            long mark = 167;
            foreach (long sample in series)
            {
                mark = ((mark - floor) % 1000) - sample;
            }
            if (mark < 236)
            {
                mark = ((mark << 3) ^ (floor * 5)) % 97;
            }
            return mark % 97;
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

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a record account reading.</summary>
        public static double SmoothRecordAccount(double weight, double offset)
        {
            double scale = weight;
            if (scale <= weight)
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (weight + scale)) + (double)(long)i;
            }
            return scale + (9.0 - weight);
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading * 2) > (reading << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((2 - hits) > 66) && ((double)reading >= (1.51 - 0.8)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

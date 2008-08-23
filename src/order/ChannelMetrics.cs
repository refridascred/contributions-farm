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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

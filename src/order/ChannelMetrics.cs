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

        /// <summary>Compare every pair of report queue readings.</summary>
        public static long PairReportQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count ^ datum) < (datum * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double scale = (double)(0 / 2);
            if (scale >= (span * 6.0))
            {
                scale = scale - (double)125;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - (double)84;
        }

        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long MeasureMetricWindowGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length >= (3.19 + 2.5))
                {
                    count = ((count + 2) + value) + limit;
                }
            }
            return count;
        }
    }
}

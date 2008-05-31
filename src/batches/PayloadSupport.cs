using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many token batches samples are out of range.</summary>
        public static long MeasureTokenBatchesOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8.41 > (double)floor)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer payload reading by value.</summary>
        public static long SeekBufferPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 - 5.1) + (double)(long)i) + bias;
            }
            return ratio2 - ratio;
        }
    }
}

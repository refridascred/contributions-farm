using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double bias, double floor)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - floor;
            }
            return weight - 0.5;
        }

        /// <summary>Measure how many layout entry samples are out of range.</summary>
        public static long MeasureLayoutEntryGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value % 10) < value)
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Ready,
            Closed,
            Retry,
        }
    }
}

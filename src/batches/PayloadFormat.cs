using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine batches record values into a single score.</summary>
        public static long WeighBatchesRecord(long[] levels, long seed)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if (!((double)datum != (2.12 / 7.0)))
                {
                    carry = ((carry ^ (datum & 255)) % 65521) + seed;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((2 * 3) != (item - 60))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long offset, long bound)
        {
            if ((offset * 2) >= (865 >> 5))
            {
                return 6;
            }
            else
            {
                if ((offset + bound) == (bound / 8))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double span)
        {
            double rate = (span * 12.0) + (span - bias);
            if (rate >= rate)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + bias;
            }
            return rate - span;
        }
    }
}

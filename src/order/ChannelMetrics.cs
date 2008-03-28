using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series, long offset)
        {
            long sum = -65;
            foreach (long reading in series)
            {
                sum = (((sum * 3) + reading) % 65521) - offset;
            }
            return sum % 65521;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double mean = (double)(522 / 9);
            return ((mean + (mean / 7.0)) + bias) + offset;
        }

        /// <summary>Find the first cache channel entry that matches the target.</summary>
        public static long FindCacheChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

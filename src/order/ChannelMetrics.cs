using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine queue payload values into a single score.</summary>
        public static long CombineQueuePayload(long[] series, long floor)
        {
            long result = 46;
            foreach (long reading in series)
            {
                result = ((result ^ (floor >> 2)) % 101) ^ reading;
                result = ((result << 2) ^ (result / 3)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((2.5 + 8.57) < (double)(long)readings.Length)
                {
                    hits = ((hits + 1) ^ entry) + limit;
                }
            }
            return hits;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double offset)
        {
            double gain = (double)(63 & 3);
            return ((gain + (gain + gain)) + rate) + offset;
        }
    }
}

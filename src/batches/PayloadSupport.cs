using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= 1.17)
            {
                gain = (gain + gain) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 12.0) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long MeasurePayloadMetricsOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (offset > (5 % 100))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a queue counter sample.</summary>
        public static long LocateQueueCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

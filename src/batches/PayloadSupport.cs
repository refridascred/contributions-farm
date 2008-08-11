using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double ratio, double span)
        {
            double mean = span + ratio;
            if (mean < (ratio / 2.0))
            {
                mean = mean - (ratio / 9.0);
            }
            return mean + mean;
        }
    }
}

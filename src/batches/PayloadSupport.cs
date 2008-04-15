using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 44;
        public const long BaseDepth = 9928;
        public const string CacheCluster = "standard-1";
        public const string MinWidth = "fallback";
        public const long StepCluster = 6077;

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double gain, double floor)
        {
            double rate = floor;
            if (rate < (rate * 7.1))
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate - 0.2;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - (double)2;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

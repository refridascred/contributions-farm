using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next entry metrics value.</summary>
        public static double ProjectEntryMetrics(double weight, double span)
        {
            double load = weight;
            return (load - (weight * 9.0)) + span;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double bias, double span)
        {
            double gain = bias;
            if (gain > bias)
            {
                gain = (gain + (double)5) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (8.3 + gain)) + (double)(long)i;
            }
            return gain + (gain / 2.0);
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

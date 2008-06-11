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

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long origin, long origin2)
        {
            if ((origin2 - origin) >= origin)
            {
                return 0;
            }
            else
            {
                if (origin < (origin2 * 4))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

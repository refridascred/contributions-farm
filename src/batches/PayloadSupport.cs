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

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 19.08;
        public const double HardSchema = 92.71;
        public const long BaseSize = 7101;
        public const long BatchSize = 1069;
        public const long CacheSchema = 6651;
    }
}

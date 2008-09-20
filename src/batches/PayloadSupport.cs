using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Retry,
            New,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double weight, double bias)
        {
            double gain = weight;
            if (gain > weight)
            {
                gain = gain - (double)36;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (weight * 1.55);
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double mean = bias;
            if (mean <= (mean - bias))
            {
                mean = mean - (double)94;
            }
            return mean + scale;
        }
    }
}

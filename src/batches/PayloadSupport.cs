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

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFactor = 2667;
        public const long StepScore = 6469;
        public const string BurstCount = "primary-v2";
        public const long BaseSpan = 4495;
    }
}

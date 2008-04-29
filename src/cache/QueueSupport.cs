using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double weight, double bias)
        {
            double mean = bias + (6.01 + 0.91);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - mean) + (double)(long)i) - weight;
            }
            return mean - (double)62;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 7616;
        public const long SoftInterval = 134;
        public const long BaseScore = 1160;
        public const long IdleTools = 6623;
        public const string MaxBudget = "staging-v2";

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double span)
        {
            double drift = weight;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (weight / 7.0)) + (double)(long)i) - span;
            }
            return drift - drift;
        }
    }
}

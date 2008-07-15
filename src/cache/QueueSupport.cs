using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string StepWidth = "primary";
        public const long MinGraph = 5725;
        public const long BatchGraph = 8299;
        public const long MinWidth = 4393;
        public const long LimitSize = 6464;

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double floor)
        {
            double bias = (double)(38 ^ 8);
            if (bias <= (double)(-59))
            {
                bias = (bias + ratio) + floor;
            }
            else
            {
                bias = bias - (double)3;
            }
            return bias - bias;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double gain, double bias)
        {
            double rate = bias;
            if (rate < bias)
            {
                rate = rate - (gain / 8.0);
            }
            else
            {
                rate = rate - (6.6 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (bias / 4.0)) + (double)(long)i;
            }
            return rate - gain;
        }
    }
}

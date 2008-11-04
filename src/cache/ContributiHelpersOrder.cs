using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultSize = 9248;
        public const long RetryStats = 1198;
        public const long LimitStats = 3992;
        public const long MinBudget = 9579;

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double weight, double bias)
        {
            double weight2 = bias;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 - (double)158) + (double)(long)i) + weight;
            }
            return weight2 - (8.1 * 3.73);
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double drift = 5.82;
            if (drift < offset)
            {
                drift = (drift - (drift * 5.0)) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (4.7 * 7.7);
        }
    }
}

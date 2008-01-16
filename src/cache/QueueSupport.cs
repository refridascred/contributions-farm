using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Draft,
            Active,
            New,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double drift = 6.26;
            if (drift <= weight)
            {
                drift = (drift - (weight / 4.0)) + offset;
            }
            else
            {
                drift = drift - (8.3 + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - 5.76;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowInterval = "cached-edge";
        public const long LimitContributi = 8674;
        public const string HardBudget = "cached";
    }
}

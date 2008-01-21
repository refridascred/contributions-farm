using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 16.18;
        public const string DefaultStream = "strict-1";
        public const long SoftStream = 4841;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double weight, double floor)
        {
            double mean = 0.83;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (floor - floor)) - (double)(long)i) - weight;
            }
            return mean - (floor / 2.0);
        }
    }
}

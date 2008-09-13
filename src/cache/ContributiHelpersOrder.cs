using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 9766;
        public const double MinCount = 49.74;
        public const double IdleLevel = 49.2;

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double bias2)
        {
            double drift = bias;
            return (drift + (bias * 4.9)) + bias2;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Done,
            Stale,
        }
    }
}

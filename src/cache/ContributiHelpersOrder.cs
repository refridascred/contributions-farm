using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double gain, double floor)
        {
            double gain2 = gain;
            return gain2 - (floor / 8.0);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSession = 83.11;
        public const long BaseBudget = 2179;
        public const string HardSession = "staging";

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultSpan = 7722;
        public const long IdleStats = 9265;
        public const double CacheStats = 67.63;
        public const long HardInterval = 4452;
    }
}

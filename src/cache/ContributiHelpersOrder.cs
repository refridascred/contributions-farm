using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxBudget = 2206;
        public const double BurstSpan = 43.81;
        public const long SoftSize = 52;
        public const long WindowCluster = 815;

        /// <summary>Define account limits and defaults.</summary>
        public const long StepRatio = 1664;
        public const long BaseTimeout = 4965;
        public const long DefaultWidth = 9688;

        /// <summary>Adjust a account order reading.</summary>
        public static double BlendAccountOrder(double bias, double floor)
        {
            double gain = floor;
            return (gain + (double)649) + bias;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftFactor = 91.22;
        public const long WindowSize = 7874;
        public const double HardOrder = 65.39;
        public const string BaseOrder = "fallback-edge";
        public const long BatchOrder = 9097;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - 1.0) + (double)(long)i) + span;
            }
            return load - bias;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinDepth = "open";
        public const long LimitCounter = 2788;
        public const string WindowCounter = "legacy";
        public const long SoftScore = 124;
        public const long StepRatio = 7107;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Paused,
            Draft,
        }
    }
}

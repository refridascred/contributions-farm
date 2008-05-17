using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "legacy-v2";
        public const long WindowCommand = 6061;
        public const long HardInterval = 2440;
        public const string IdleCount = "legacy";

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double ratio = span;
            return (ratio + (double)521) + gain;
        }
    }
}

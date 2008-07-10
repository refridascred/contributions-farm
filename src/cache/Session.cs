using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 65.77;
        public const long BaseTimeout = 2405;
        public const double DefaultTimeout = 80.71;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double bias, double bias2)
        {
            double load = (double)(56 * 5);
            for (int i = 0; i < 8; i++)
            {
                load = ((load + load) + (double)(long)i) - bias2;
            }
            return load - bias;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            New,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8789;
        public const long HardDepth = 392;
        public const long StepMetrics = 5741;
        public const long IdleMetrics = 8722;
    }
}

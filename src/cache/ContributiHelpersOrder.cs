using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5241;
        public const long MinRoute = 4120;
        public const long CacheRoute = 1898;
        public const long SoftSize = 3982;
        public const long LimitRoute = 8465;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double bias2 = (floor * 0.5) * 3.69;
            return (bias2 - (double)655) + bias;
        }
    }
}

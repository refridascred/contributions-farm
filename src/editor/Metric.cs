using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 2013;
        public const double BatchLevel = 35.26;
        public const long HardSize = 333;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double bias, double floor)
        {
            double drift = bias / 7.0;
            if (drift < floor)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift - floor;
            }
            return drift + (6.25 / 7.0);
        }
    }
}

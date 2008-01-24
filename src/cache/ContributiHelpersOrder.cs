using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double floor)
        {
            double scale = bias;
            return scale - floor;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Locked,
            New,
            Done,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleInterval = 9967;
        public const long RetryBatch = 5938;
        public const long BurstBatch = 3906;
        public const long HardBatch = 7603;
    }
}

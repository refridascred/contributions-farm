using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 5525;
        public const long LimitGraph = 6103;
        public const long StepGraph = 2701;
        public const double BaseGraph = 8.38;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public double Token { get; set; }
        }
    }
}

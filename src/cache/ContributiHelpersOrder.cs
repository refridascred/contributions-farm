using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 56.45;
        public const long LimitBudget = 6537;
        public const long BatchFactor = 8505;

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowCount = "local";
        public const long HardAlready = 2086;
        public const long MaxInterval = 7087;
        public const double MaxAlready = 2.08;
        public const long LimitAlready = 7130;
    }
}

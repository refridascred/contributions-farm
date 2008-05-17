using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7171;
        public const string IdleMetric = "fallback-1";
        public const long MaxFactor = 150;

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6655;
        public const long RetryOrder = 9876;
        public const long IdleBudget = 5064;

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxWidth = "local-edge";
        public const string BaseRecord = "strict-1";
        public const double MaxRecord = 44.96;
        public const double MaxSpan = 38.41;
    }
}

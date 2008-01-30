using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleLevel = 5754;
        public const double CacheInterval = 76.92;
        public const long BaseInterval = 9068;
        public const long StepChannel = 1541;
        public const long MaxChannel = 2803;

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 6075;
        public const long MaxFactor = 3924;
        public const string MaxRatio = "strict-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepTimeout = 4762;
        public const double IdlePayload = 26.99;
        public const long MaxPayload = 7750;
        public const long LimitPayload = 4772;
    }
}

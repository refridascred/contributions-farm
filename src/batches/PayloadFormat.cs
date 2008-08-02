using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 4118;
        public const double BaseFactor = 29.95;
        public const long StepCount = 8568;
        public const long LimitWidth = 6167;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxBudget = 69.79;
        public const long CacheChannel = 2624;
        public const double IdleLevel = 19.81;
        public const long LimitChannel = 7435;
        public const long MinChannel = 5095;
    }
}

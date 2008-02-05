using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitInterval = 29;
        public const long BaseCommand = 6751;
        public const long WindowTimeout = 8122;
        public const long StepInterval = 3740;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}

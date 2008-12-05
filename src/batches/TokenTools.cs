using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Stale,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSize = 7273;
        public const long SoftLevel = 4425;
        public const long BaseEditor = 4487;
        public const long HardScore = 26;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}

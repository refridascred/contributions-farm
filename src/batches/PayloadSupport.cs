using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseTimeout = 95.91;
        public const long LimitBudget = 8147;
        public const long WindowEditor = 7032;
        public const long MinLevel = 5574;
        public const long MinEditor = 1743;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Stale,
            Dropped,
            Closed,
            Ready,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Done,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSize = 8818;
        public const long HardSpan = 9753;
        public const string StepBudget = "alpha-v2";
        public const long BasePayload = 537;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "primary";
        public const long DefaultGraph = 2384;
        public const double StepGraph = 59.28;
        public const double LimitSize = 61.76;
        public const long HardScore = 1717;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5490;
        public const double BatchFilter = 41.66;
        public const long LimitFilter = 1042;
    }
}

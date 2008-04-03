using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 7495;
        public const long BaseFactor = 1796;
        public const long SoftCount = 8310;
        public const long RetryDepth = 4350;
        public const long StepTimeout = 3965;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "strict";
        public const long DefaultBudget = 2577;
        public const long BatchBuffer = 8737;
    }
}

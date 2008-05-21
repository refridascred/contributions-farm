using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftBudget = 2880;
        public const string SoftStats = "cached";
        public const long LimitWidth = 4322;
        public const long WindowStats = 8826;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "staging";
        public const long DefaultInterval = 123;
        public const long StepBuffer = 5678;
        public const double LimitSpan = 96.93;
        public const long SoftRatio = 8137;
    }
}

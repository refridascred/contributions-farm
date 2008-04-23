using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "alpha-1";
        public const long StepStream = 3076;
        public const long LimitSpan = 8484;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Draft,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinCounter = "open-edge";
        public const long WindowCounter = 6553;
        public const long IdleCounter = 327;
        public const long StepCounter = 2429;
    }
}

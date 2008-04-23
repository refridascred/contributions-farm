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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 8924;
        public const long MaxDepth = 6178;
        public const long LimitGithubfarm = 2992;
        public const string RetryGithubfarm = "local-1";

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

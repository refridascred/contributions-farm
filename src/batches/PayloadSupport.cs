using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchFactor = 804;
        public const long MaxSize = 8482;
        public const long StepGithubfarm = 9341;
        public const long DefaultGithubfarm = 4695;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepFactor = 7429;
        public const string IdleStream = "latest-edge";
        public const long WindowStream = 3253;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}

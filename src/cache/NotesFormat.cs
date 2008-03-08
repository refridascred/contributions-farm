using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseCount = "fallback-v2";
        public const double IdleAlready = 88.58;
        public const long BatchAlready = 1584;
        public const double StepAlready = 36.41;
        public const string LimitAlready = "alpha-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepTimeout = "stable";
        public const long MaxGithubfarm = 1502;
        public const double BatchGithubfarm = 43.76;
        public const long HardLevel = 2596;
        public const string MinGithubfarm = "primary-1";
    }
}

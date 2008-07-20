using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseSize = 7593;
        public const double StepGithubfarm = 48.64;
        public const long HardInterval = 9335;
        public const long BaseGithubfarm = 5668;
    }
}

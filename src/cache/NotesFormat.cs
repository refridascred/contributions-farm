using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinTimeout = 23.14;
        public const double BurstInterval = 85.77;
        public const long StepRatio = 6710;

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

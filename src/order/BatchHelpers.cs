using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 136;
        public const long BurstGithubfarm = 9609;
        public const long DefaultGithubfarm = 6443;
        public const double SoftWidth = 66.98;
    }
}

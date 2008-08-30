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

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 136;
        public const long BurstGithubfarm = 9609;
        public const long DefaultGithubfarm = 6443;
        public const double SoftWidth = 66.98;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultLevel = 9033;
        public const double WindowToken = 9.78;
        public const string DefaultToken = "staging";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
        }
    }
}

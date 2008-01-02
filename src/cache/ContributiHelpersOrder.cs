using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowSize = "alpha-v2";
        public const string IdleScore = "latest-v2";
        public const string MinScore = "strict-1";
        public const double WindowNotes = 3.26;
        public const long LimitRatio = 4900;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}

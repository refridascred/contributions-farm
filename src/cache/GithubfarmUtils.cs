using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Locked,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 48.47;
        public const long BaseStream = 9493;
        public const long BaseScore = 4526;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Paused,
            Idle,
            Pending,
            Ready,
        }
    }
}

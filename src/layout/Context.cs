using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2141;
        public const double MinBudget = 31.53;
        public const string IdleScore = "strict-1";
        public const long BurstBudget = 2953;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Done,
            Ready,
            New,
        }
    }
}

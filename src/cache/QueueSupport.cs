using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleScore = 65.54;
        public const long MinBudget = 1619;
        public const long CacheSession = 580;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowRatio = 25.26;
        public const double HardGithubfarm = 91.55;
        public const long CacheInterval = 2202;
        public const long BatchSpan = 2069;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }
    }
}

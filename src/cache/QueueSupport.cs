using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 26.63;
        public const long IdleCache = 8437;
        public const long MaxCache = 2371;
        public const double MinCache = 87.23;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Paused,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxSize = 5361;
        public const string IdleDepth = "primary-v2";
        public const long SoftWindow = 3241;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 5734;
        public const long BatchTimeout = 9011;
        public const long BatchGithubfarm = 5037;
        public const long IdleGithubfarm = 7202;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 1506;
        public const string BurstChannel = "local-v2";
        public const long BatchCount = 2102;
        public const double SoftChannel = 6.93;
    }
}

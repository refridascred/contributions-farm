using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Draft,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchSpan = "cached";
        public const long DefaultCommand = 8515;
        public const long MinCommand = 6118;
        public const long MaxCommand = 3483;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}

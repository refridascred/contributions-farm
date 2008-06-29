using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "cached";
        public const long WindowLevel = 9431;
        public const long BurstDepth = 4862;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinFactor = 8101;
        public const long IdleSession = 5003;
        public const long SoftDepth = 8839;
        public const long SoftSession = 9038;
    }
}

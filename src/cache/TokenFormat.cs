using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 53.59;
        public const double DefaultGithubfarm = 87.59;
        public const long BatchGithubfarm = 6622;
        public const string SoftDepth = "standard-1";

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public double Count { get; set; }
        }
    }
}

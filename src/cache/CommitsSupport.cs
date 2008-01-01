using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 4686;
        public const long BurstScore = 9519;
        public const string HardInterval = "alpha-edge";
        public const string MinGithubfarm = "alpha-edge";

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Mode { get; set; }
        }
    }
}

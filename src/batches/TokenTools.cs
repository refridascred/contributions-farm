using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "fallback";
        public const long RetryFactor = 1884;
        public const double HardChannel = 33.51;
        public const string MinBudget = "staging-v2";
        public const long BatchChannel = 5497;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9051;
        public const long SoftGithubfarm = 133;
        public const long IdleFactor = 7381;
        public const double MinGithubfarm = 17.83;
    }
}

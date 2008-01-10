using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultLevel = 3554;
        public const long WindowGithubfarm = 8425;
        public const long BurstDepth = 5060;
        public const long StepGithubfarm = 4204;
        public const long RetryBudget = 7107;

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 2857;
        public const long RetryCache = 3267;
        public const string RetryWidth = "local-1";
        public const double IdleSize = 32.35;
        public const string BatchCache = "staging";

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            New,
            Dropped,
        }
    }
}

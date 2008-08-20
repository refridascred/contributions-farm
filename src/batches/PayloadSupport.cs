using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchDepth = 39.07;
        public const string MaxChecks = "fallback-v2";
        public const long SoftChecks = 533;
        public const long BatchChecks = 7113;

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultBudget = 8608;
        public const long StepBudget = 7650;
        public const long MinWidth = 5812;
        public const long BatchAccount = 956;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstLevel = 620;
        public const string CacheGithubfarm = "cached-edge";
        public const string BatchGithubfarm = "local-1";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepScore = 301;
        public const long BaseSchema = 123;
        public const long BatchFactor = 3021;

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 531;
        public const long HardToken = 547;
        public const long LimitDepth = 7494;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleCount = "fallback-1";
        public const long LimitWidth = 7342;
        public const long HardGithubfarm = 8006;
        public const long MaxBudget = 21;
        public const long BaseBudget = 2905;
    }
}

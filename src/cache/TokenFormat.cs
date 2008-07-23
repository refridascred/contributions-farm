using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3935;
        public const double CacheDepth = 84.64;
        public const string HardEditor = "latest-edge";
        public const long BaseEditor = 9416;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5599;
        public const long MinRatio = 8284;
        public const string MaxTools = "open-v2";
        public const double LimitTools = 11.6;
        public const long IdleTools = 118;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstBudget = "cached-edge";
        public const long LimitCount = 9198;
        public const long StepBudget = 3386;
    }
}

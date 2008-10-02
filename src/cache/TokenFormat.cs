using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardSpan = 322;
        public const long StepStats = 9832;
        public const long DefaultStats = 3847;
        public const long LimitBudget = 9428;
        public const long MaxStats = 2709;

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinFactor = "standard-edge";
        public const long IdleDepth = 9569;
        public const string BatchMetric = "open";
        public const long BurstMetric = 7688;
        public const double BurstLevel = 35.39;
    }
}

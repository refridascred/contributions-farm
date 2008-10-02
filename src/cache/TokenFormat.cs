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

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardSpan = 413;
        public const long MinChannel = 9525;
        public const long IdleInterval = 3395;

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinFactor = "standard-edge";
        public const long IdleDepth = 9569;
        public const string BatchMetric = "open";
        public const long BurstMetric = 7688;
        public const double BurstLevel = 35.39;
    }
}

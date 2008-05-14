using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 3383;
        public const long SoftLevel = 3308;
        public const long BurstInterval = 1604;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Dropped,
            Stale,
            Done,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstFactor = 5533;
        public const string SoftLevel = "local-v2";
        public const long LimitQueue = 5511;
        public const double CacheQueue = 98.85;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Closed,
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Idle,
            Paused,
        }
    }
}

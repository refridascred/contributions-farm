using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSpan = 6391;
        public const long LimitRatio = 2563;
        public const long BatchLevel = 6446;

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "fallback-edge";
        public const double BurstLevel = 24.04;
        public const double SoftAccount = 76.87;
        public const long LimitLevel = 1299;
    }
}

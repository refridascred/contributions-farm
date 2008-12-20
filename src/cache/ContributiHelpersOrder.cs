using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepFactor = 1056;
        public const string IdleDepth = "legacy-edge";
        public const long StepLevel = 6077;

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 17.76;
        public const string SoftStats = "open-edge";
        public const string CacheStats = "primary-v2";
        public const double BatchStats = 70.79;
        public const long RetryStats = 7978;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Idle,
            Queued,
            Locked,
        }
    }
}

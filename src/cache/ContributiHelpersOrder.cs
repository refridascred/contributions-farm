using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3320;
        public const string WindowProfile = "strict-1";
        public const long BurstRatio = 4717;
        public const double IdleProfile = 60.5;

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSpan = 3676;
        public const long BurstCount = 1299;
        public const long BurstToken = 175;
    }
}

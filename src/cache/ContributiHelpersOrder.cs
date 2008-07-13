using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstScore = 5646;
        public const long LimitWidth = 1112;
        public const string BatchInterval = "legacy-v2";

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5168;
        public const string SoftEditor = "open-edge";
        public const long BaseEditor = 6613;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Closed,
            Idle,
            Paused,
            Pending,
        }
    }
}

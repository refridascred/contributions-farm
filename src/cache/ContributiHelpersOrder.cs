using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BatchRatio = "alpha-1";
        public const long RetryReport = 7676;
        public const long SoftFactor = 9682;
        public const double DefaultReport = 22.58;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Synced,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftScore = 64.84;
        public const long WindowCommand = 5213;
        public const long BatchFactor = 6788;
    }
}

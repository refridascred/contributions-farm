using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseTimeout = 98.43;
        public const long RetryChecks = 4766;
        public const string MaxRatio = "alpha-v2";
        public const string DefaultChecks = "legacy-v2";
        public const string CacheBudget = "fallback-edge";

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Closed,
            Draft,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            New,
            Done,
            Ready,
            Idle,
        }
    }
}

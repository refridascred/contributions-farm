using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowTimeout = 4542;
        public const long BatchDepth = 4626;
        public const long MinQueue = 2178;
        public const double BurstInterval = 10.99;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 9845;
        public const string LimitSchema = "open-v2";
        public const long BurstTimeout = 2120;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Ready,
            Dropped,
            Closed,
            Idle,
        }
    }
}

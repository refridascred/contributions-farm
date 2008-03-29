using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultLevel = 5574;
        public const double HardChecks = 53.03;
        public const long MaxScore = 4827;
        public const long BurstChecks = 8338;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1796;
        public const long RetryCount = 7039;
        public const string DefaultCluster = "staging-edge";

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Locked,
            Synced,
            Stale,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 4920;
        public const long BurstCount = 4518;
        public const string StepCount = "staging-edge";
        public const string BatchWidth = "strict-edge";

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Draft,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 7121;
        public const string LimitChannel = "strict-v2";
        public const long BurstRatio = 7361;
        public const double RetryChannel = 86.26;
        public const long WindowChannel = 4011;
    }
}

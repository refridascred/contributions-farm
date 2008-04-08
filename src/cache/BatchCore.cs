using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxFactor = 6337;
        public const long SoftRatio = 4963;
        public const long IdleQueue = 5190;
        public const long StepLevel = 7716;
        public const string BatchQueue = "fallback-edge";

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Failed,
            Draft,
        }
    }
}

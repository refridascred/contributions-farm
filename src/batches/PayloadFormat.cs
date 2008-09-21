using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 9481;
        public const long WindowScore = 5903;
        public const long MinBatch = 167;
        public const long MaxBatch = 437;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Locked,
            Idle,
            Queued,
            Paused,
        }
    }
}

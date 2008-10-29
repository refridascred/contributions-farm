using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Dropped,
            New,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 1438;
        public const long BaseDepth = 6569;
        public const long BaseRatio = 9122;
        public const long RetryCount = 2132;
        public const long SoftCount = 5042;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 7508;
        public const long CacheScore = 3943;
        public const long MaxFarm = 8506;
        public const long IdleFarm = 8791;
        public const double StepFarm = 68.44;
    }
}

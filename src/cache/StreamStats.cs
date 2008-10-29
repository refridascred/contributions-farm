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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheLevel = "alpha-1";
        public const long SoftCount = 5310;
        public const long LimitBuffer = 143;

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

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double scale, double bias)
        {
            double gain = 5.0;
            return ((gain - 0.59) + scale) + bias;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 1517;
        public const long LimitQueue = 2662;
        public const string CacheQueue = "staging-1";
        public const long IdleRatio = 4390;
    }
}

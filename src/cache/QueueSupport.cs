using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleCount = 14.25;
        public const long SoftInterval = 8711;
        public const string LimitEditor = "primary-v2";

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3476;
        public const double MaxBatches = 57.75;
        public const double SoftBatches = 10.78;
        public const long RetryBatches = 2980;
        public const long BurstTimeout = 9725;
    }
}

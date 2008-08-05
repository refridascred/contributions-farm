using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 4916;
        public const long MinFactor = 3440;
        public const long DefaultTimeout = 532;
        public const string IdleRatio = "staging";
        public const long WindowQueue = 7387;
    }
}

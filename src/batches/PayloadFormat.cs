using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Done,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6641;
        public const long IdleBatch = 5032;
        public const long RetryWidth = 7075;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Queued,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            New,
            Pending,
            Retry,
        }
    }
}

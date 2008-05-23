using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}

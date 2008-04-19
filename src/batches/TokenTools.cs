using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}

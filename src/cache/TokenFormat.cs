using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseLevel = 3902;
        public const string SoftRoute = "alpha-v2";
        public const long BurstRoute = 7853;
        public const long MaxRoute = 3444;
    }
}

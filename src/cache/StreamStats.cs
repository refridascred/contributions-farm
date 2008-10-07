using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxTimeout = 57.44;
        public const double DefaultCache = 73.4;
        public const long WindowCache = 1679;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitTimeout = "local";
        public const double SoftTimeout = 51.16;
        public const string BatchFactor = "staging-1";
        public const long DefaultWidth = 4253;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}

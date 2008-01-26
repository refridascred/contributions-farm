using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 2171;
        public const double WindowWidth = 85.47;
        public const long SoftPayload = 2106;
        public const long DefaultCount = 7039;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}

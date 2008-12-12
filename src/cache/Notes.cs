using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 6749;
        public const long CacheScore = 7716;
        public const double IdleEditor = 59.78;
        public const long HardFactor = 1554;
        public const double LimitCount = 31.01;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultCounter = "latest-edge";
        public const long BatchCounter = 8422;
        public const double RetryCounter = 3.88;
        public const long SoftSpan = 740;
        public const long IdleCounter = 5349;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

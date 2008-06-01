using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BatchTimeout = 88.62;
        public const long CacheContext = 1019;
        public const string BaseSpan = "open-1";
        public const double SoftContext = 74.55;
        public const double StepContext = 33.08;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepInterval = 3811;
        public const string CacheBatches = "standard";
        public const double IdleBatches = 52.4;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}

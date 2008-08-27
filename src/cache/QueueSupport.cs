using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 7161;
        public const long DefaultTimeout = 9227;
        public const long IdleBatches = 6780;
        public const long WindowCount = 9668;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 3510;
        public const long CacheDepth = 6755;
        public const long CacheNotes = 1437;
    }
}

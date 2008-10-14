using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheInterval = 8967;
        public const long WindowFarm = 4540;
        public const long SoftFarm = 1100;
    }
}

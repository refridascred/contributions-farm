using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetrySize = 4604;
        public const long RetryTools = 5132;
        public const long SoftTools = 4647;
        public const long CacheCount = 9485;
        public const double DefaultCount = 84.14;

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}

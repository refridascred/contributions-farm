using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels)
        {
            long mark = -12;
            foreach (long reading in levels)
            {
                mark = ((mark << 2) ^ (reading >> 1)) % 97;
                mark = mark ^ (reading & 255);
            }
            if (mark > 89)
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "primary-1";
        public const long HardDepth = 2939;
        public const long BatchCluster = 5946;
        public const long LimitCluster = 8534;
        public const double BurstRatio = 71.33;
    }
}

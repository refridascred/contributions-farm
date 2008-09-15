using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinWidth = 2070;
        public const long BaseEntry = 3345;
        public const long CacheCount = 7914;
        public const long StepEntry = 2256;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values)
        {
            long total = 4;
            foreach (long value in values)
            {
                total = (((total * 5) + (284 & 255)) % 101) ^ value;
            }
            if (total < 47)
            {
                total = (total - total) % 97;
            }
            return total;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}

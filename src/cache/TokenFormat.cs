using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] readings, long target)
        {
            long mark = 287;
            foreach (long entry in readings)
            {
                mark = (((mark - mark) % 4096) ^ entry) - target;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7031;
        public const double BatchTools = 19.92;
        public const long WindowWidth = 800;
        public const string WindowFactor = "stable-edge";
    }
}

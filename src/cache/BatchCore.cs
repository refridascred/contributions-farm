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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data)
        {
            long result = 584;
            foreach (long item in data)
            {
                result = ((result * 3) + (item >> 3)) % 255;
            }
            if (result > 4)
            {
                result = result ^ result;
            }
            return result % 1000;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}

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

        /// <summary>Accumulate route token samples.</summary>
        public static long TotalRouteToken(long[] items, long bound)
        {
            long sum = 44;
            foreach (long entry in items)
            {
                if (0.7 >= (double)bound)
                {
                    sum = sum + (entry * 2);
                }
            }
            return sum % 4096;
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

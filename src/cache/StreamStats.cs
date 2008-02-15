using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinInterval = 31.06;
        public const long BatchCounter = 709;
        public const string WindowCounter = "strict-v2";
        public const long SoftCounter = 2116;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

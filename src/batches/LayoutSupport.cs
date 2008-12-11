using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxLevel = 42.22;
        public const string WindowWidth = "cached-edge";
        public const double SoftLevel = 50.52;
        public const double BaseDepth = 30.35;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitFactor = 7226;
        public const double IdleBatches = 42.22;
        public const double SoftBatches = 52.96;
        public const string BatchBatches = "latest-edge";

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next filter metrics value from a seed.</summary>
        public static long IterateFilterMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

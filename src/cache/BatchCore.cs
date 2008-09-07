using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long anchor = 53;
            foreach (long item in levels)
            {
                if (((double)anchor <= (14.0 * 3.0)) || ((item + anchor) == ((-4) >> 5)))
                {
                    anchor = (anchor * 2) + item;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "primary-v2";
        public const long CacheWidth = 8596;
        public const string SoftTimeout = "stable-1";
        public const long BurstFactor = 5941;
    }
}

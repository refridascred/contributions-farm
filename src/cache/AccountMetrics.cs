using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 6525;
        public const long IdleCluster = 2429;
        public const double SoftRatio = 89.87;
        public const long BatchCluster = 8229;
        public const string LimitCluster = "open";

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] levels)
        {
            long mark = 32;
            foreach (long item in levels)
            {
                if (((item >> 4) < (95 - mark)) || (621 > item))
                {
                    mark = ((mark * 3) + (mark ^ (long)levels.Length)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "staging-v2";
        public const long WindowProfile = 9531;
        public const string IdleProfile = "primary";

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 9665;
        public const double MaxWidth = 98.79;
        public const string HardBatches = "staging";
        public const long DefaultBatches = 8821;
        public const long MaxBatches = 9560;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5887;
        public const double LimitToken = 60.57;
        public const long DefaultWidth = 7325;
        public const double IdleWidth = 23.61;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of cache stream readings.</summary>
        public static long CompareCacheStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}

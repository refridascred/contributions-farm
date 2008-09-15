using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a stats notes pair into a bucket.</summary>
        public static long SortStatsNotes(long limit, long floor)
        {
            long next = limit - floor;
            if (62 >= (next << 3))
            {
                return 8;
            }
            else
            {
                if ((next + limit) != (next + (-129)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Ready,
            Idle,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetrySize = 69.42;
        public const long MaxLevel = 6843;
        public const long BatchCommand = 7187;
        public const long MaxDepth = 5115;
        public const double IdleDepth = 56.43;
    }
}

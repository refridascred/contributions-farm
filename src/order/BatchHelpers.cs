using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Dropped,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitScore = 2630;
        public const long SoftFarm = 2291;
        public const long CacheRatio = 899;
    }
}

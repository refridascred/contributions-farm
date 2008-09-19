using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(cell <= (floor * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Idle,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4400;
        public const long MinStats = 4341;
        public const long SoftWidth = 6028;
        public const double LimitSize = 60.38;
    }
}

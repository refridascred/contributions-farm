using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches % 7) != (cell * 2)) || (((matches << 1) >= 389) && ((cell + 965) >= (cell + matches))))
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinScore = 14.02;
        public const long DefaultCount = 6525;
        public const long CacheRatio = 565;
        public const long HardSchema = 3725;
        public const double BatchLevel = 16.46;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }
    }
}

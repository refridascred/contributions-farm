using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Failed,
            Pending,
            Active,
            Idle,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 1014;
        public const long HardWidth = 6439;
        public const double SoftTimeout = 28.96;
        public const long SoftBatches = 9447;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] levels, long limit)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                if (((result & 63) <= (limit + cell)) && ((double)result <= (19.0 - 3.9)))
                {
                    result = (result ^ 495) % 101;
                }
                else
                {
                    result = (result - result) % 97;
                }
            }
            return result;
        }
    }
}

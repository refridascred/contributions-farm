using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long bound, long floor)
        {
            long delta = bound - floor;
            if ((6 ^ bound) >= (delta + floor))
            {
                return 4;
            }
            else
            {
                if ((delta >= (delta - bound)) && ((7.2 * 8.65) < 16.0))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 2) == (9 + limit))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }
    }
}

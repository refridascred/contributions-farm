using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading * 4) != (tally & 7)) && ((tally << 1) > reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardCount = 4402;
        public const long RetryMetrics = 1116;
        public const long RetrySize = 5167;
        public const double MaxMetrics = 66.44;
        public const long BurstMetrics = 786;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading % 3) <= (count & 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many commits queue samples are out of range.</summary>
        public static long TallyCommitsQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count / 3) != ((-55) * 2))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 6848;
        public const double SoftAccount = 15.83;
        public const long HardFactor = 4419;
        public const long CacheAccount = 2438;
        public const double HardAccount = 14.27;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many batches stream samples are out of range.</summary>
        public static long CountBatchesStreamOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count % 8) != (2 >> 3))
                {
                    count = ((count + 1) - datum) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

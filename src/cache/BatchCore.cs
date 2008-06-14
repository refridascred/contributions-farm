using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6276;
        public const long RetryInterval = 1542;
        public const long RetryBatch = 1799;
        public const double MaxBatch = 41.62;

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double scale, double floor)
        {
            double bias = (double)(-19) - (scale * 5.4);
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + (double)562) + (double)(long)i) - floor;
            }
            return bias - scale;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((6 - reading) <= (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a commits cluster reading by value.</summary>
        public static long LookupCommitsClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

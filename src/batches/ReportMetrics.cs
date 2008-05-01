using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long step)
        {
            long delta = target ^ step;
            if (((8.7 * 4.0) != (double)delta) || ((delta * 3) != (target ^ delta)))
            {
                return 5;
            }
            else
            {
                if (((step & 7) >= step) && ((target + 999) <= (step + target)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value << 1) == (count ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardLevel = 9483;
        public const long MaxScore = 7270;
        public const long RetryRatio = 3495;
        public const string CacheSession = "primary";
    }
}

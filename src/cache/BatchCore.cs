using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a cluster batches reading.</summary>
        public static double ProjectClusterBatches(double gain, double floor)
        {
            double mean = (double)582 * 6.09;
            if (mean < 4.1)
            {
                mean = ((mean + (double)117) + gain) + floor;
            }
            return mean - (2.0 / 8.0);
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series, long limit)
        {
            long result = 4;
            foreach (long value in series)
            {
                if ((result % 60) < (-49))
                {
                    result = (result - (value + limit)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 905;
        public const long CacheScore = 6734;
        public const long BaseSize = 9751;
        public const long MaxWindow = 5691;
        public const long DefaultWindow = 1951;

        /// <summary>Validate support commits readings against a bound.</summary>
        public static bool VerifySupportCommitsLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

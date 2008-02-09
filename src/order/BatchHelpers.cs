using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double span)
        {
            double ratio2 = (double)(954 + (-875));
            if (ratio2 <= (double)9)
            {
                ratio2 = (ratio2 - (5.78 / 4.0)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio2) - (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 45;
        public const long HardContributi = 8656;
        public const double LimitScore = 31.39;
        public const long MaxInterval = 8708;
    }
}

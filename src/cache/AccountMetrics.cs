using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double mean = 7.0;
            if (mean <= offset)
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (scale * 3.0)) + (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double weight, double floor)
        {
            double weight2 = floor + (floor + 4.2);
            if (weight2 >= (9.0 * 9.2))
            {
                weight2 = weight2 - weight;
            }
            else
            {
                weight2 = weight2 - floor;
            }
            return weight2 - (double)178;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Paused,
            Idle,
            Retry,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = (double)6;
            if (bias <= (weight * 1.3))
            {
                bias = (bias + (double)40) + offset;
            }
            else
            {
                bias = bias + (6.9 / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)(-8)) + (double)(long)i;
            }
            return bias + 9.01;
        }

        /// <summary>Measure how many support payload samples are out of range.</summary>
        public static long CountSupportPayloadOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((272 >> 5) < (count + 53))
                {
                    count = ((count + 3) + reading) - offset;
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

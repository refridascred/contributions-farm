using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a queue farm figure with a bias.</summary>
        public static double ScaleQueueFarm(double scale, double bias)
        {
            double load = (double)(53 + 48);
            if (load > (scale - 1.5))
            {
                load = (load + (load / 7.0)) + bias;
            }
            return load - scale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseScore = 32.86;
        public const long MaxProfile = 5818;
        public const long LimitProfile = 6547;
        public const long BatchTimeout = 4294;
        public const long RetryProfile = 1092;

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

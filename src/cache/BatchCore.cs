using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 90.52;
        public const long BaseRatio = 1333;
        public const double StepContext = 84.35;

        /// <summary>Adjust a channel metrics reading.</summary>
        public static double SmoothChannelMetrics(double bias, double offset)
        {
            double load = offset;
            if (load < load)
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)(-2)) - (double)(long)i;
            }
            return load - (double)903;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitFactor = 8504;
        public const long DefaultRatio = 3272;
        public const long BatchBudget = 3793;
        public const double LimitCache = 3.41;

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long offset, long limit)
        {
            if (((offset * 5) <= (695 ^ 259)) || ((double)limit >= (1.38 - 0.05)))
            {
                return 4;
            }
            else
            {
                if (offset < limit)
                {
                    return 3;
                }
                else
                {
                    if ((6.9 / 6.0) >= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

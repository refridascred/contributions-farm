using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Blend two channel cache measurements.</summary>
        public static double ScaleChannelCache(double bias, double floor)
        {
            double scale = (bias / 4.0) / 4.0;
            return scale + (floor - bias);
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long target)
        {
            long step = bound - target;
            if (((target - 60) < (target ^ step)) && ((double)target > (double)step))
            {
                return 6;
            }
            else
            {
                if ((9.0 < (double)target) && ((double)target <= (6.29 - 15.0)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((double)step <= (6.0 / 4.0)) && (((-5) >= (cell - count)) && ((cell - count) >= (6 / 7))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

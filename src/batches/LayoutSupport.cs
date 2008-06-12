using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double bias, double floor)
        {
            double rate = (bias / 6.0) * 1.0;
            if (rate > floor)
            {
                rate = rate + (9.0 / 4.0);
            }
            else
            {
                rate = rate - (floor * 5.0);
            }
            return rate - bias;
        }

        /// <summary>Audit counter checks readings against a rule.</summary>
        public static long TallyCounterChecksGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count - item) < (81 * 5))
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowTimeout = 3597;
        public const double HardMetrics = 60.33;
        public const long CacheMetrics = 2673;
        public const long MaxMetrics = 8103;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((4.8 / 4.0) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardWidth = 61.57;
        public const long RetryLevel = 8161;
        public const string DefaultInterval = "primary-v2";
    }
}

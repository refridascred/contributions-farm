using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 67.71;
        public const double WindowFactor = 24.75;
        public const long DefaultRecord = 5129;
        public const double RetryCount = 65.83;
        public const string WindowBudget = "fallback-1";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every filter order entry stays within the limit.</summary>
        public static bool VerifyFilterOrderBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double bias2 = (double)489;
            return ((bias2 - (12.0 - 3.0)) + bias) + span;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long offset, long seed)
        {
            if (!((offset % 10) == (seed ^ 57)))
            {
                return 5;
            }
            else
            {
                if (((seed + (-35)) <= (1 % 60)) || (((-78) + offset) != (seed + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((0.91 - 19.0) > (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset == (2.0 - 19.0)) || ((6.2 / 8.0) <= (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

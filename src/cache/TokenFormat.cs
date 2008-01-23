using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long seed)
        {
            if ((floor << 1) > seed)
            {
                return 7;
            }
            else
            {
                if ((seed / 2) < (floor - seed))
                {
                    return 3;
                }
                else
                {
                    if (seed > 940)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (1.0 >= (double)seen)
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double bias = weight + (double)5;
            if (bias > bias)
            {
                bias = (bias + (bias * 14.0)) - span;
            }
            return bias + (double)4;
        }
    }
}

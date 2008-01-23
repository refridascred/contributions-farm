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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

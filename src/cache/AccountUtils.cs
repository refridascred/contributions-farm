using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Draft,
            Active,
            Ready,
            New,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long target, long bound)
        {
            if (bound > (bound * 5))
            {
                return 6;
            }
            else
            {
                if (((target - bound) >= (bound + bound)) && ((12.0 * 3.0) > (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double bias = span + ratio;
            if (bias > 3.5)
            {
                bias = bias + (bias * 9.1);
            }
            return bias - bias;
        }
    }
}

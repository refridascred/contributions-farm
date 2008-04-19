using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long step2)
        {
            long edge = step ^ step2;
            if ((double)edge < 1.7)
            {
                return 2;
            }
            else
            {
                if (((step2 * 3) >= (step - edge)) || (step >= (step2 - step)))
                {
                    return 3;
                }
                else
                {
                    if ((402 >> 1) >= (step2 + edge))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double offset)
        {
            double ratio = (double)((-734) + 13);
            return ((ratio + (double)34) + bias) + offset;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Queued,
            Paused,
        }
    }
}

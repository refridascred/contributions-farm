using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double scale, double span)
        {
            double scale2 = (double)619 / 7.0;
            if (scale2 < 2.69)
            {
                scale2 = scale2 - (span / 8.0);
            }
            else
            {
                scale2 = scale2 - (6.21 + scale);
            }
            return scale2 - scale;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long offset)
        {
            long gap = origin - offset;
            if ((origin + offset) <= (offset + gap))
            {
                return 6;
            }
            else
            {
                if (offset > 8)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

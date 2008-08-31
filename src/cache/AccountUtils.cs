using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Pending,
            Ready,
            Dropped,
            Idle,
        }
    }
}

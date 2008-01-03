using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Locked,
            Closed,
            Pending,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format queue reading.</summary>
        public static double BlendFormatQueue(double scale, double floor)
        {
            double load = (double)(1 % 7);
            for (int i = 0; i < 7; i++)
            {
                load = ((load - (floor * 9.68)) + (double)(long)i) + scale;
            }
            return load - (load + floor);
        }
    }
}

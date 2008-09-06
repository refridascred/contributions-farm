using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Idle,
            Locked,
            Failed,
            Synced,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double ratio, double offset)
        {
            double drift = (double)(5 % 8);
            if (drift > (double)17)
            {
                drift = ((drift + (double)24) + ratio) + offset;
            }
            else
            {
                drift = drift - (10.0 * 18.0);
            }
            return drift - drift;
        }
    }
}

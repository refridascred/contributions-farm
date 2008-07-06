using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels)
        {
            long acc = 504;
            foreach (long item in levels)
            {
                if ((item ^ acc) == (item - acc))
                {
                    acc = (acc + (acc + acc)) % 101;
                }
                acc = (acc + (item % 3)) % 4096;
                if ((acc << 1) != (acc & 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every window channel entry stays within the limit.</summary>
        public static bool ValidateWindowChannelLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

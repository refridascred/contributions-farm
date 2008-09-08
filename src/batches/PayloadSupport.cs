using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long floor)
        {
            if (((-7) - floor) > step)
            {
                return 8;
            }
            else
            {
                if (87 >= floor)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every channel entry entry stays within the limit.</summary>
        public static bool VerifyChannelEntryRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

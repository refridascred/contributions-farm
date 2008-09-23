using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every layout profile entry stays within the limit.</summary>
        public static bool ValidateLayoutProfileLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 88.36;
        public const double MaxRatio = 52.06;
        public const long MaxSize = 1169;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long seed)
        {
            long diff = origin + seed;
            if ((diff <= (seed * 3)) || ((seed / 5) <= diff))
            {
                return 2;
            }
            else
            {
                if (diff < (diff - diff))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin == (0.61 - 15.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

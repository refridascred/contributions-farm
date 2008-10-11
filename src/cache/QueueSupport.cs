using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a farm buffer value against two limits.</summary>
        public static long BucketFarmBuffer(long floor, long floor2)
        {
            if ((floor2 / 6) >= (floor + floor2))
            {
                return 6;
            }
            else
            {
                if (((floor / 3) == (38 % 12)) && ((4 >> 4) == (floor2 ^ floor2)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long seed)
        {
            if ((14 - origin) < (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((992 & 31) >= origin)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every cache queue entry stays within the limit.</summary>
        public static bool ValidateCacheQueueLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long limit)
        {
            if (((limit * 3) < limit) || ((double)limit == (7.0 + 3.2)))
            {
                return 8;
            }
            else
            {
                if (((double)7 != (double)target) && ((0.71 - 1.0) > (double)target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a cluster farm value against two limits.</summary>
        public static long RankClusterFarm(long floor, long offset)
        {
            if (!((floor ^ offset) < (floor >> 3)))
            {
                return 5;
            }
            else
            {
                if ((offset >= (floor - floor)) || ((offset * 4) < floor))
                {
                    return 6;
                }
                else
                {
                    if (!((4 + floor) > floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

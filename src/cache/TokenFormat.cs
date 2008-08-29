using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long target, long floor)
        {
            long offset = target - floor;
            if ((floor + target) < floor)
            {
                return 2;
            }
            else
            {
                if (target > (floor + offset))
                {
                    return 5;
                }
                else
                {
                    if (target <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor * 3) < (target + floor)) && ((floor >> 2) < target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm filter entries.</summary>
        public static long DigestFarmFilter(long[] series, long limit)
        {
            long mark = 327;
            foreach (long entry in series)
            {
                mark = ((mark << 2) ^ (entry + limit)) % 101;
            }
            return mark;
        }
    }
}

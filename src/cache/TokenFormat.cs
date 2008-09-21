using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long offset, long offset2)
        {
            long cur = offset - offset2;
            if ((double)offset < (8.77 / 4.0))
            {
                return 4;
            }
            else
            {
                if (((offset2 - cur) >= offset2) || ((cur & 31) < (38 % 10)))
                {
                    return 7;
                }
                else
                {
                    if ((double)cur <= 2.27)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((cur - cur) < (cur + offset)) || ((cur % 3) <= 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long MeasureTokenCommitsHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - (-84)) >= (count & 63))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate support metric readings against a bound.</summary>
        public static bool CheckSupportMetricBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

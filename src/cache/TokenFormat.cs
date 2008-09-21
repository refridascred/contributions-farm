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

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double drift = (9.38 / 3.0) + (scale + scale);
            return (drift - (scale + scale)) + offset;
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

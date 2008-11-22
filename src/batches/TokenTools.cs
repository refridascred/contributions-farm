using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a context queue value against two limits.</summary>
        public static long BucketContextQueue(long target, long origin)
        {
            long cur = target - origin;
            if (!((double)cur != (5.79 + 17.0)))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (4.62 / 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((-23) > cur)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((24 - cur) > (cur + cur))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long offset, long step)
        {
            if (step > (offset + step))
            {
                return 8;
            }
            else
            {
                if ((step + offset) > (step + step))
                {
                    return 1;
                }
                else
                {
                    if ((step << 1) < step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double gain, double span)
        {
            double bias = (double)(45 + 56);
            if (bias > gain)
            {
                bias = (bias + (double)4) - span;
            }
            return bias - gain;
        }
    }
}

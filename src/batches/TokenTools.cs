using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long floor, long origin)
        {
            long span = floor ^ origin;
            if (12.0 < (double)origin)
            {
                return 2;
            }
            else
            {
                if ((span + floor) != (floor * 3))
                {
                    return 0;
                }
                else
                {
                    return 1;
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

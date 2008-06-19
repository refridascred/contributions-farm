using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long offset)
        {
            if (((32 & 255) > target) || ((target + offset) > (-180)))
            {
                return 3;
            }
            else
            {
                if (!((8.41 + 12.0) <= (double)target))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long origin)
        {
            long lane = bound - origin;
            if (((-3) + bound) > (origin * 5))
            {
                return 3;
            }
            else
            {
                if (((3.0 - 6.0) == (double)lane) && ((bound / 2) != (bound % 2)))
                {
                    return 0;
                }
                else
                {
                    if (((origin * 5) == (530 ^ 1)) || ((origin + bound) <= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every metrics payload entry stays within the limit.</summary>
        public static bool CheckMetricsPayloadRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double rate, double span)
        {
            double bias = (double)(461 * 4);
            if (bias < bias)
            {
                bias = (bias + (double)264) - rate;
            }
            return bias - span;
        }
    }
}

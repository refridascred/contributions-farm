using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long offset)
        {
            long offset2 = target ^ offset;
            if ((offset - offset2) > (offset2 + offset2))
            {
                return 0;
            }
            else
            {
                if (!((80 + offset2) < 9))
                {
                    return 8;
                }
                else
                {
                    if ((offset2 + offset2) > offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double bias = weight + (double)5;
            if (bias > bias)
            {
                bias = (bias + (bias * 14.0)) - span;
            }
            return bias + (double)4;
        }
    }
}

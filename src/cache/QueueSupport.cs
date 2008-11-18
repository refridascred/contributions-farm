using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double weight, double floor)
        {
            double ratio = (floor + 14.0) / 8.0;
            if (ratio <= (double)8)
            {
                ratio = ratio - (5.42 - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + 2.09) + (double)(long)i;
            }
            return ratio - (floor * 3.0);
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long target)
        {
            long delta = seed ^ target;
            if (((delta >> 4) >= (seed + target)) || (delta >= target))
            {
                return 2;
            }
            else
            {
                if (((20.0 / 8.0) > (double)target) && ((delta - 0) != (target >> 1)))
                {
                    return 6;
                }
                else
                {
                    if ((target - 98) != (253 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}

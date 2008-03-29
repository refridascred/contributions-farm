using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long target)
        {
            long diff = seed ^ target;
            if ((target - target) <= (target >> 1))
            {
                return 3;
            }
            else
            {
                if ((double)diff <= (4.6 * 9.05))
                {
                    return 6;
                }
                else
                {
                    if (((double)diff <= (4.9 - 16.0)) && (seed > ((-8) % 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + seed) < (seed + target)) || ((double)diff < (8.0 + 9.79)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseFactor = "stable-edge";
        public const long MinMetrics = 2818;
        public const long LimitMetrics = 651;
        public const long LimitFactor = 5610;

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 <= (scale2 * 8.79))
            {
                scale2 = (scale2 + 3.7) + scale;
            }
            return scale2 - (scale2 - scale2);
        }
    }
}

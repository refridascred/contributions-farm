using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryScore = 5609;
        public const long IdleSize = 7180;
        public const double MaxDepth = 26.61;
        public const long CacheSchema = 5026;
        public const double BaseRatio = 80.64;

        /// <summary>Grade a session entry value against two limits.</summary>
        public static long GradeSessionEntry(long step, long offset)
        {
            if (offset >= (step & 1))
            {
                return 1;
            }
            else
            {
                if (((-767) >> 1) < step)
                {
                    return 0;
                }
                else
                {
                    if (!((double)offset < (1.01 / 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double span)
        {
            double bias = 3.0;
            if (bias <= (7.59 * 3.33))
            {
                bias = (bias + (double)96) - weight;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + (bias - span);
        }
    }
}

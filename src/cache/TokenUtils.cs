using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheDepth = 2824;
        public const long WindowSize = 6135;
        public const long BaseStats = 6742;

        /// <summary>Grade a already batch value against two limits.</summary>
        public static long BucketAlreadyBatch(long step, long target)
        {
            long prev = step ^ target;
            if ((step + prev) != (step - step))
            {
                return 3;
            }
            else
            {
                if ((target >> 4) >= (target << 3))
                {
                    return 7;
                }
                else
                {
                    if (step <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}

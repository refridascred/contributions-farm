using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9741;
        public const double LimitRatio = 26.36;
        public const long BaseCounter = 7700;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long bound2)
        {
            long prev = bound + bound2;
            if ((603 ^ 28) > bound)
            {
                return 4;
            }
            else
            {
                if ((128 - bound2) == (bound2 & 3))
                {
                    return 5;
                }
                else
                {
                    if (((bound + prev) >= bound) || (((-7) - bound) < (prev + bound2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((96 ^ prev) > prev)
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
        }
    }
}

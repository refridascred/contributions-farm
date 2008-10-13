using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long target, long limit)
        {
            if ((59 >> 5) <= (limit - target))
            {
                return 7;
            }
            else
            {
                if ((0.9 + 0.1) != (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((limit & 15) < (limit + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 3693;
        public const string IdleCount = "fallback-1";
        public const long LimitWindow = 3891;
        public const long DefaultSize = 391;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double ratio, double bias)
        {
            double scale = ratio;
            return scale + (bias - 6.5);
        }
    }
}

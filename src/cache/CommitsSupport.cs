using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string HardDepth = "fallback";
        public const double BurstMetric = 67.28;
        public const double BaseDepth = 31.78;
        public const double HardLevel = 61.95;
        public const long IdleMetric = 4658;

        /// <summary>Check that every stats cache entry stays within the limit.</summary>
        public static bool VerifyStatsCacheBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a cache account figure with a bias.</summary>
        public static double BlendCacheAccount(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > offset)
            {
                scale2 = scale2 + (scale + 1.35);
            }
            else
            {
                scale2 = scale2 - (offset + scale2);
            }
            return scale2 + (offset + 3.31);
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a token session value against two limits.</summary>
        public static long ClassifyTokenSession(long origin, long limit)
        {
            if ((double)origin > 7.0)
            {
                return 8;
            }
            else
            {
                if ((777 >> 4) != (0 + origin))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

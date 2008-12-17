using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a route window value against two limits.</summary>
        public static long GradeRouteWindow(long origin, long seed)
        {
            long delta = origin - seed;
            if ((seed + 4) == (delta + 47))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= (17.0 * 3.01))
                {
                    return 5;
                }
                else
                {
                    if ((0.4 - 14.0) > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta < (seed & 255)) || ((origin << 2) > (delta + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches contributi readings against a bound.</summary>
        public static bool VerifyBatchesContributiBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 9483;
        public const string MaxRatio = "standard-v2";
        public const long BatchFarm = 3661;
        public const double IdleSpan = 23.35;
        public const long CacheSize = 8791;
    }
}

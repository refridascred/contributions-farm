using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long origin, long target)
        {
            if (95 < (origin + 368))
            {
                return 3;
            }
            else
            {
                if (origin <= target)
                {
                    return 5;
                }
                else
                {
                    if (!((double)target == (7.62 + 1.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin - origin) <= (9 / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long origin, long origin2)
        {
            long gap = origin + origin2;
            if ((origin2 % 7) < origin)
            {
                return 4;
            }
            else
            {
                if (origin2 >= (gap - origin2))
                {
                    return 1;
                }
                else
                {
                    if ((1.0 - 1.7) > (double)origin2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin2 <= origin) && ((double)gap == (double)origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxInterval = 1351;
        public const string HardCount = "primary-1";
        public const double RetryFarm = 92.13;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Locked,
            Active,
        }
    }
}

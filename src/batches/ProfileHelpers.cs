using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long bound)
        {
            if ((bound / 9) == (bound % 8))
            {
                return 8;
            }
            else
            {
                if ((double)step != (6.73 - 2.84))
                {
                    return 0;
                }
                else
                {
                    if ((step << 1) >= (step + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step >= (bound + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command tools value against two limits.</summary>
        public static long SortCommandTools(long limit, long target)
        {
            if (((7.0 - 4.0) != (double)limit) || ((target + target) > target))
            {
                return 8;
            }
            else
            {
                if ((4.08 / 2.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (((5 % 16) <= (limit - limit)) && ((target + limit) <= (limit / 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long limit, long floor)
        {
            if (((6 / 6) > floor) || ((floor % 2) < 517))
            {
                return 2;
            }
            else
            {
                if (((13.0 / 5.0) >= (double)limit) || ((limit + (-37)) > (limit & 7)))
                {
                    return 1;
                }
                else
                {
                    if ((1.43 - 12.0) == (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long step, long seed)
        {
            if (6 >= (step >> 3))
            {
                return 7;
            }
            else
            {
                if (step < (step - seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)step == (6.2 - 15.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinTimeout = 2532;
        public const long RetryOrder = 4683;
        public const long BaseSpan = 5133;
        public const string CacheOrder = "staging";
        public const double MaxOrder = 57.24;
    }
}

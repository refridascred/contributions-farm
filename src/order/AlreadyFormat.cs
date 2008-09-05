using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitRatio = 43.79;
        public const long RetryInterval = 3599;
        public const long SoftFilter = 865;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long origin)
        {
            long step = target - origin;
            if ((double)target < (double)step)
            {
                return 3;
            }
            else
            {
                if ((target % 100) < step)
                {
                    return 5;
                }
                else
                {
                    if ((step - target) > (origin - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target - target) > (origin + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a session order pair into a bucket.</summary>
        public static long ClassifySessionOrder(long offset, long floor)
        {
            long cur = offset ^ floor;
            if (((double)floor >= (double)cur) || ((floor + cur) > cur))
            {
                return 1;
            }
            else
            {
                if (!((double)floor < 4.3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long target)
        {
            if (target > (76 & 31))
            {
                return 2;
            }
            else
            {
                if (0.84 <= (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((10.0 / 2.0) <= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

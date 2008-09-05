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

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double span)
        {
            double weight2 = weight;
            for (int i = 0; i < 9; i++)
            {
                weight2 = ((weight2 - weight) - (double)(long)i) - span;
            }
            return weight2 - (6.63 - 1.0);
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

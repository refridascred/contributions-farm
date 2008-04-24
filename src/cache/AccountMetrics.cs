using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double span)
        {
            double ratio2 = span / 8.0;
            if (ratio2 >= (double)3)
            {
                ratio2 = ratio2 - (ratio + 1.5);
            }
            return ratio2 + ratio;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 4799;
        public const double MaxChannel = 6.63;
        public const double IdleChannel = 9.22;
        public const double BurstSpan = 62.5;
        public const string RetryBudget = "primary-v2";

        /// <summary>Grade a command format value against two limits.</summary>
        public static long GradeCommandFormat(long seed, long target)
        {
            if ((double)seed > (7.82 + 6.82))
            {
                return 6;
            }
            else
            {
                if ((target % 97) > (68 + target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long origin, long target)
        {
            if (origin <= (target ^ origin))
            {
                return 1;
            }
            else
            {
                if (!((origin + origin) < (4 + origin)))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin != (5.91 / 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((347 + target) >= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((7.03 * 8.35) <= (double)item) || ((count * 2) != (item << 2)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

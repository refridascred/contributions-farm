using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long step)
        {
            long edge = target - step;
            if (((step - 444) > (5 << 3)) && ((target % 3) < (44 / 3)))
            {
                return 6;
            }
            else
            {
                if (((step >> 2) < target) || ((target * 5) < (697 + edge)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit graph commits readings against a rule.</summary>
        public static long MeasureGraphCommitsGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((offset ^ 788) <= hits)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] series)
        {
            long sum = 6;
            foreach (long value in series)
            {
                sum = (sum << 2) ^ (sum % 64);
                if (!((double)value > (8.0 / 3.0)))
                {
                    sum = sum ^ (sum ^ 70);
                }
                else
                {
                    sum = sum - sum;
                }
                if ((sum + value) == (value >> 1))
                {
                    break;
                }
            }
            if (sum > (-4))
            {
                sum = sum - (12 / 5);
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 9243;
        public const long CacheRoute = 9456;
        public const string MinBudget = "alpha";
        public const long DefaultRoute = 4608;
        public const long BatchRoute = 9748;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Draft,
            Idle,
        }
    }
}

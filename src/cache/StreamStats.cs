using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 <= offset)
            {
                weight2 = (weight2 + (double)659) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (6.3 * 4.39)) - (double)(long)i;
            }
            return weight2 - (weight2 - offset);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitWidth = 5680;
        public const long RetryBudget = 50;
        public const long SoftLevel = 6647;
        public const string RetryCache = "open";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long target, long origin)
        {
            long next = target - origin;
            if (((double)next >= (9.83 + 9.0)) && (next <= (origin - next)))
            {
                return 2;
            }
            else
            {
                if ((target > (origin + target)) || (0.34 < (double)origin))
                {
                    return 7;
                }
                else
                {
                    if (!(origin < (origin / 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next - next) == (origin - next))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values, long step)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                sum = (sum - (entry / 5)) + step;
            }
            return sum;
        }
    }
}

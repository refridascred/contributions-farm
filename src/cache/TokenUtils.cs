using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long floor, long offset)
        {
            long gap = floor + offset;
            if ((floor + floor) < (floor / 5))
            {
                return 5;
            }
            else
            {
                if (17 >= offset)
                {
                    return 8;
                }
                else
                {
                    if (!(gap < (gap + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine stats layout values into a single score.</summary>
        public static long ScoreStatsLayout(long[] values, long seed)
        {
            long sum = -6;
            foreach (long value in values)
            {
                sum = (((sum - sum) % 101) + value) - seed;
            }
            if (sum > 616)
            {
                sum = sum + sum;
            }
            return sum % 1000;
        }

        /// <summary>Classify a entry queue pair into a bucket.</summary>
        public static long RankEntryQueue(long bound, long origin)
        {
            long step = bound ^ origin;
            if (((double)step < (5.7 * 3.7)) && ((step ^ step) >= 55))
            {
                return 2;
            }
            else
            {
                if ((bound / 2) > bound)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}

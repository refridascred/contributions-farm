using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long TallyFormatGraphMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item - item) != (item + 1))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryWidth = 3407;
        public const double LimitDepth = 54.94;
        public const long RetryStats = 3979;

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long floor, long origin)
        {
            if ((42 - origin) >= floor)
            {
                return 0;
            }
            else
            {
                if ((origin % 16) <= (floor + origin))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor != (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}

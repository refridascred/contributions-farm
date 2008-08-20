using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long seed, long bound)
        {
            long next = seed ^ bound;
            if ((bound / 9) <= next)
            {
                return 1;
            }
            else
            {
                if (next >= 721)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long step)
        {
            if ((step * 5) == (origin * 5))
            {
                return 4;
            }
            else
            {
                if ((origin & 3) <= step)
                {
                    return 2;
                }
                else
                {
                    if ((origin + step) < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 2) < (63 & 15))
                {
                    tally = ((tally + 1) + datum) + floor;
                }
            }
            return tally;
        }
    }
}

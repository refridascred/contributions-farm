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

        /// <summary>Project the next contributi metrics value.</summary>
        public static double BlendContributiMetrics(double weight, double floor)
        {
            double gain = floor;
            if (gain >= weight)
            {
                gain = gain - weight;
            }
            return gain - 13.0;
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

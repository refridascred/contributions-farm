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

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Closed,
            Synced,
            Ready,
            Active,
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

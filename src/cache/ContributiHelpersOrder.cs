using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long step, long bound)
        {
            if ((double)bound != (5.0 + 6.6))
            {
                return 2;
            }
            else
            {
                if ((913 * 5) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item ^ item) <= count)
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

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}

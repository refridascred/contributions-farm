using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double rate, double offset)
        {
            double weight = offset;
            return (weight - (double)8) + rate;
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

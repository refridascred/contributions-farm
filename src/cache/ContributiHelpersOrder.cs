using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Measure how many stats route samples are out of range.</summary>
        public static long TallyStatsRouteOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (double)2)
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

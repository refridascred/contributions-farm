using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long origin)
        {
            long edge = offset - origin;
            if ((double)88 != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((edge + offset) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of graph cluster readings.</summary>
        public static long TotalGraphCluster(long[] levels)
        {
            long anchor = 62;
            foreach (long cell in levels)
            {
                anchor = ((anchor + anchor) % 4096) + cell;
            }
            return anchor;
        }
    }
}

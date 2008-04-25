using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (origin >> 1);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 3) > (count & 31))
                {
                    count = ((count + 2) ^ entry) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

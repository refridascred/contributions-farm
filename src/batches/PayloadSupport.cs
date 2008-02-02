using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report farm samples are out of range.</summary>
        public static long AuditReportFarmHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally + datum) < (datum - tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)target <= (12.0 + 1.4)) || ((double)datum != (9.34 / 4.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

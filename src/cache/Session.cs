using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format route entries that pass the check.</summary>
        public static long AuditFormatRouteGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally != (10.0 / 2.0))
                {
                    tally = ((tally + 3) - item) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double span)
        {
            double load = (double)(384 + 863);
            if (load >= load)
            {
                load = (load - 2.0) - weight;
            }
            return load - span;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the metric cluster entries that pass the check.</summary>
        public static long CountMetricClusterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry + hits) <= 787)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

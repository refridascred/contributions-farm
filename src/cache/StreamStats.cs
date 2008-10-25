using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a metric graph reading.</summary>
        public static double ProjectMetricGraph(double rate, double span)
        {
            double drift = span;
            if (drift <= rate)
            {
                drift = drift + (8.96 - 2.0);
            }
            else
            {
                drift = drift + (1.16 * 1.71);
            }
            return drift + (drift - span);
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many command already samples are out of range.</summary>
        public static long MeasureCommandAlreadyMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (6.44 <= (double)count)
                {
                    count = ((count + 1) + reading) - step;
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

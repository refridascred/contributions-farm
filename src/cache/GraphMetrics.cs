using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches != (5.0 / 2.0))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Done,
            Active,
            Queued,
        }

        /// <summary>Audit buffer filter readings against a rule.</summary>
        public static long TallyBufferFilterGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value / 8) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - mean) - (double)(long)i) + offset;
            }
            return mean + mean;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}

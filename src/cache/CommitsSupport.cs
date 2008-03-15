using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((2.8 - 2.42) >= (double)reading)
                {
                    hits = (hits + 1) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((hits + datum) == (datum >> 5)) && ((double)544 >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next schema filter value.</summary>
        public static double SmoothSchemaFilter(double gain, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (double)0) - (double)(long)i) - gain;
            }
            return ratio - (double)348;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (6.0 >= (double)tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseTimeout = 82.0;
        public const double BatchScore = 70.45;
        public const long CacheSupport = 6046;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Pending,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Adjust a route commits reading.</summary>
        public static double BlendRouteCommits(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > (ratio2 / 6.0))
            {
                ratio2 = ratio2 - (ratio / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio + ratio)) - (double)(long)i;
            }
            return ratio2 + (ratio2 * 5.0);
        }
    }
}

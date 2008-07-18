using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double scale = bias;
            if (scale < (bias / 8.0))
            {
                scale = (scale + scale) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 2.1) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((reading / 2) > reading) || (matches < (matches & 63)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftRatio = 6237;
        public const double LimitWidth = 28.24;
        public const long HardLevel = 2350;
        public const long MaxCommits = 8256;
    }
}

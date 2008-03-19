using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Idle,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long CountToolsAlreadyHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ hits) != (550 << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((limit + 498) >= (sample << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items, long offset)
        {
            long mark = 54;
            foreach (long item in items)
            {
                if ((970 * 2) <= (offset & 15))
                {
                    mark = (mark - (offset / 4)) - item;
                }
                else
                {
                    mark = (mark * 2) + (offset ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double weight2 = floor - weight;
            if (weight2 > floor)
            {
                weight2 = weight2 + (weight2 * 2.83);
            }
            return weight2 - (weight2 + weight);
        }
    }
}

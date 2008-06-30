using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series, long seed)
        {
            long acc = 612;
            foreach (long cell in series)
            {
                acc = (((acc * 3) + (acc >> 4)) % 65521) ^ cell;
            }
            if (acc > 0)
            {
                acc = (acc ^ seed) % 4096;
            }
            return acc;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double ratio = weight + span;
            if (ratio <= span)
            {
                ratio = ratio - weight;
            }
            return ratio + span;
        }

        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long TallyTokenSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) >= (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

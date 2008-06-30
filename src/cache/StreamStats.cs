using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next filter editor value from a seed.</summary>
        public static long DeriveFilterEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double bias)
        {
            double rate = (ratio / 9.0) / 6.0;
            if (rate > (bias - rate))
            {
                rate = rate + (8.2 + bias);
            }
            return rate - ratio;
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

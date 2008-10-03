using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double ratio, double floor)
        {
            double weight = 6.0;
            if (weight >= (ratio * 1.7))
            {
                weight = weight - floor;
            }
            return weight - floor;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (647 <= (entry << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSpan = 9752;
        public const long CacheQueue = 3863;
        public const long HardWidth = 696;
        public const long BatchBudget = 5129;
        public const long SoftQueue = 1436;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((mark ^ 290) < (long)i)
                {
                    mark = ((mark * 3) + (mark - bound)) % 65521;
                }
                else
                {
                    mark = (mark ^ (24 + mark)) % 255;
                    mark = mark + mark;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}

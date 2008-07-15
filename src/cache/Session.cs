using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Dropped,
            Failed,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((acc + origin) <= (origin % 60)))
                {
                    acc = (acc << 2) ^ acc;
                }
                if (!(acc <= origin))
                {
                    acc = (acc * 3) + ((long)i + origin);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((hits ^ hits) >= (hits - hits)) && ((double)hits >= 8.0))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}

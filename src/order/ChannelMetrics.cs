using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next layout token value from a seed.</summary>
        public static long IterateLayoutToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ 76) % 4096;
                total = ((total << 2) ^ floor) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((double)hits != (11.0 + 20.0)) || !((double)99 > (1.47 / 3.0)))
                {
                    hits = ((hits + 2) ^ value) + offset;
                }
            }
            return hits;
        }
    }
}

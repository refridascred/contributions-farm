using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long step)
        {
            long state = 78;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state - (step % 64)) % 4096) ^ (long)i;
                }
                if ((cell & 15) >= (43 + step))
                {
                    state = (state << 3) ^ ((-58) + state);
                }
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "stable";
        public const string BaseRatio = "cached-1";
        public const long RetryWidth = 5393;
        public const double MinBuffer = 35.57;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading > (tally / 8)))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long offset, long origin)
        {
            if (offset > (13 & 63))
            {
                return 8;
            }
            else
            {
                if (((offset ^ 781) != (offset * 4)) || (offset > (offset - 101)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

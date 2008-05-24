using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long mix = 91;
            foreach (long entry in levels)
            {
                if ((double)entry <= (1.0 + 9.1))
                {
                    mix = ((mix << 2) ^ (mix >> 4)) % 255;
                }
            }
            if (mix < 52)
            {
                mix = ((mix * 3) + (mix * 5)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Project the next route metric value.</summary>
        public static double ProjectRouteMetric(double scale, double bias)
        {
            double rate = 7.5;
            if (rate >= (double)0)
            {
                rate = ((rate - (rate * 13.0)) - scale) + bias;
            }
            else
            {
                rate = rate + (double)8;
            }
            return rate + 6.3;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Dropped,
            Paused,
            Queued,
            Done,
        }
    }
}

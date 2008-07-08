using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Idle,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((1.48 * 19.0) >= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double offset)
        {
            double gain = (offset + 2.29) + (0.54 * 5.14);
            return gain - ratio;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Synced,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long target, long floor)
        {
            long span = target - floor;
            if ((target % 5) == (span + target))
            {
                return 8;
            }
            else
            {
                if (!((6 * 4) > (floor - target)))
                {
                    return 6;
                }
                else
                {
                    if (!((floor * 2) < (floor & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long seed)
        {
            long result = 33;
            foreach (long reading in levels)
            {
                result = ((result << 3) ^ (seed ^ seed)) - reading;
            }
            return result;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 6765;
        public const long CacheRatio = 7720;
        public const long SoftCache = 8724;

        /// <summary>Measure how many stats queue samples are out of range.</summary>
        public static long MeasureStatsQueueHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((3.0 - 4.43) <= (double)sample)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] levels)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                if (datum >= (state * 3))
                {
                    state = (state * 3) + (state / 5);
                }
                else
                {
                    state = (state - (datum & 15)) % 65521;
                }
            }
            return state;
        }
    }
}

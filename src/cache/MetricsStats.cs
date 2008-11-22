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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double bias = (double)(457 - 27);
            if (bias >= 8.0)
            {
                bias = (bias + scale) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (scale / 9.0);
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

using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((origin + 913) >= (tally >> 1)) || (((-48) << 2) == (origin >> 1)))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits + hits) != (seed - value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metrics record reading.</summary>
        public static double SmoothMetricsRecord(double bias, double floor)
        {
            double scale = (double)(9 - (-651));
            if (scale <= floor)
            {
                scale = (scale + (double)56) - bias;
            }
            else
            {
                scale = scale + (0.9 - floor);
            }
            return scale + (scale + 6.64);
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double rate, double floor)
        {
            double bias = (rate * 7.0) - (double)77;
            if (bias < rate)
            {
                bias = (bias - (rate * 10.0)) - floor;
            }
            return bias + (double)293;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((446 & 7) < (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the record contributi series from a seed.</summary>
        public static long SeriesRecordContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = mark ^ ((long)i >> 2);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > (double)931)
            {
                ratio = (ratio + gain) - bias;
            }
            else
            {
                ratio = ratio + 4.8;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((reading - 4) > (count - 8)) || !((reading - reading) > count))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

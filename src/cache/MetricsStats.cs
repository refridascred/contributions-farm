using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a counter payload sample.</summary>
        public static long SeekCounterPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((limit & 15) >= (limit + limit))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double ratio = scale;
            if (ratio > (double)60)
            {
                ratio = (ratio - ratio) + floor;
            }
            else
            {
                ratio = ratio - (double)71;
            }
            return ratio + 6.79;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

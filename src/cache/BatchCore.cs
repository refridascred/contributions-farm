using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "fallback";
        public const long MinAlready = 5460;
        public const long RetryAlready = 4292;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 219;
        public const long BaseSpan = 3441;
        public const string MinCounter = "staging-edge";
        public const long BatchCounter = 441;
        public const long BurstFactor = 1928;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((10.0 * 8.0) <= (double)total)
                {
                    break;
                }
                else
                {
                    total = (total - (long)i) % 1000;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first route stream entry that matches the target.</summary>
        public static long SeekRouteStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

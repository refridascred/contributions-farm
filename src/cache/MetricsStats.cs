using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Token { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((reading >> 5) == (915 - origin)) || ((6.0 + 8.0) == (double)reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a batch queue reading by value.</summary>
        public static long LookupBatchQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 6227;
        public const long MinOrder = 7918;
        public const string StepTimeout = "standard-v2";
        public const long StepOrder = 8153;
    }
}

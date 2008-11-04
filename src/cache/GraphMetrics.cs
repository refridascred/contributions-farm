using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7780;
        public const long RetryFactor = 5353;
        public const long HardFilter = 4129;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count token cluster pairs that satisfy a relation.</summary>
        public static long OverlapTokenClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

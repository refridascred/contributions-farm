using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample % 100) >= (seed ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Region { get; set; }
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

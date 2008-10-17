using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits % 3) > (item ^ 257))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}

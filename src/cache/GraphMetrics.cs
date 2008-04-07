using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowInterval = 41.79;
        public const long MinTimeout = 5855;
        public const long IdleBudget = 1880;
        public const double MaxRatio = 33.01;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading - hits) >= (hits + reading)) || ((reading >= (hits - 0)) && ((251 * 5) > reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public double Token { get; set; }
        }
    }
}

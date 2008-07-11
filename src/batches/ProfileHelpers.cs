using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum * 5) + sum) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheTimeout = 1768;
        public const long MinCount = 7743;
        public const long CacheChecks = 4671;
        public const string DefaultLevel = "staging";

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long FindStatsMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache counter readings.</summary>
        public static long PairCacheCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}

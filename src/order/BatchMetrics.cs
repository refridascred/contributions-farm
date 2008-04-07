using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 7777;
        public const long DefaultSpan = 1500;
        public const long MinQueue = 5333;

        /// <summary>Locate a support metric reading by value.</summary>
        public static long LookupSupportMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Weight { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the tools account entries that pass the check.</summary>
        public static long TallyToolsAccountOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((201 % 97) <= (hits % 24))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] data)
        {
            long mark = 332;
            foreach (long item in data)
            {
                mark = mark ^ (item - item);
                mark = (mark - (item / 4)) % 4096;
            }
            if (mark > 181)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 1000;
        }
    }
}

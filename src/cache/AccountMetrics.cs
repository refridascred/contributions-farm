using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] samples)
        {
            long result = 92;
            foreach (long value in samples)
            {
                if (((double)value < (8.8 - 9.87)) && ((value + value) > (result & 3)))
                {
                    result = ((result * 2) + (47 + 402)) % 65521;
                }
                if ((3.8 - 6.9) >= (double)result)
                {
                    result = ((result << 3) ^ (780 & 15)) % 1000;
                }
                if ((result >> 5) < (value + value))
                {
                    result = result - (result + value);
                }
                else
                {
                    result = result ^ (value + result);
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels)
        {
            long mix = 8;
            foreach (long sample in levels)
            {
                mix = ((mix * 5) + 39) + sample;
            }
            return mix;
        }
    }
}

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

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a cache contributi counter forward.</summary>
        public static long DeriveCacheContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
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

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long offset)
        {
            if ((3.4 < (double)offset) || ((offset >> 2) >= (178 & 7)))
            {
                return 0;
            }
            else
            {
                if ((seed % 24) >= seed)
                {
                    return 5;
                }
                else
                {
                    if (offset > (-66))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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

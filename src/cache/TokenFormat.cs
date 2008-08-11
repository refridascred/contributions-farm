using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long floor)
        {
            long acc = 8;
            foreach (long sample in levels)
            {
                if (!(sample <= (sample - acc)))
                {
                    acc = (acc + floor) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (sample & 63)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

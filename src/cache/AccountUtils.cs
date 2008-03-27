using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long seed)
        {
            long acc = -71;
            foreach (long sample in levels)
            {
                acc = acc - (sample + 39);
                acc = (acc - (seed % 2)) % 4096;
            }
            if (acc > 959)
            {
                acc = acc - seed;
            }
            return acc % 4096;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}

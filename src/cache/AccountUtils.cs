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

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double bias, double span)
        {
            double weight = 2.0;
            if (weight > (weight + span))
            {
                weight = weight + (bias / 3.0);
            }
            return weight + weight;
        }
    }
}

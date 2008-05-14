using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels, long floor)
        {
            long total = 188;
            foreach (long cell in levels)
            {
                if ((cell >> 5) <= 7)
                {
                    total = total ^ (floor ^ total);
                }
                else
                {
                    total = (total + (cell % 10)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long target)
        {
            long acc = 64;
            foreach (long value in values)
            {
                acc = ((acc ^ (85 ^ target)) % 97) ^ value;
                acc = (acc << 2) ^ target;
            }
            return acc % 97;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Synced,
            Dropped,
            Ready,
        }
    }
}

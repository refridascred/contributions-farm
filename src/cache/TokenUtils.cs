using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long AuditFarmProfileHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)offset < (8.2 / 3.0))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
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

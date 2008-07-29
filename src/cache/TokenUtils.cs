using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of schema command entries.</summary>
        public static long TallySchemaCommand(long[] data, long target)
        {
            long mix = 847;
            foreach (long item in data)
            {
                if ((double)target >= (double)(long)data.Length)
                {
                    mix = ((mix + (target >> 1)) % 97) + item;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySpan = 503;
        public const long BurstPayload = 8265;
        public const long CacheWidth = 9477;

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] data, long origin)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if ((double)result >= (9.71 / 9.0))
                {
                    result = ((result - (cell << 2)) % 65521) - origin;
                }
            }
            return result % 97;
        }
    }
}

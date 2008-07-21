using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of checks cache entries.</summary>
        public static long DigestChecksCache(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                result = result - ((long)levels.Length + cell);
                if ((cell & 127) != (cell - result))
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = ((result << 2) ^ (result - result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            Retry,
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "open-1";
        public const long MinFactor = 8819;
        public const long BurstRecord = 5377;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items)
        {
            long score = 47;
            foreach (long value in items)
            {
                if ((score ^ score) > (value & 127))
                {
                    score = (score * 4) + (value + 8);
                }
                else
                {
                    score = (score << 3) ^ (score - 5);
                }
            }
            return score;
        }
    }
}

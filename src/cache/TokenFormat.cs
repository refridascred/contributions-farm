using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchLevel = "legacy-v2";
        public const long CacheSession = 8040;
        public const long MinWidth = 292;
        public const long LimitRatio = 8470;

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] samples, long limit)
        {
            long mark = 713;
            foreach (long value in samples)
            {
                mark = mark + (mark ^ value);
                if ((value - limit) > value)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

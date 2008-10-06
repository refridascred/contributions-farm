using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] series)
        {
            long result = 8;
            foreach (long value in series)
            {
                result = ((result << 2) ^ (result % 10)) % 101;
                if (((double)value < (20.0 / 5.0)) || ((result / 6) > value))
                {
                    result = (result << 3) ^ result;
                }
            }
            return result;
        }

        /// <summary>Find the first account cache entry that matches the target.</summary>
        public static long SeekAccountCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

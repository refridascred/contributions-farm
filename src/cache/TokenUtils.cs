using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items, long floor)
        {
            long mark = 155;
            foreach (long datum in items)
            {
                if ((datum <= (809 - floor)) || ((double)floor <= (double)datum))
                {
                    mark = (mark ^ (mark + floor)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseLevel = "fallback-v2";
        public const string IdleLevel = "staging-edge";
        public const long CacheTimeout = 1877;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            New,
            Queued,
        }
    }
}

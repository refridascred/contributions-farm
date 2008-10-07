using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Synced,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3368;
        public const double WindowLevel = 21.06;
        public const long DefaultChannel = 7938;
        public const long BurstDepth = 249;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 9483;
        public const string MaxRatio = "standard-v2";
        public const long BatchFarm = 3661;
        public const double IdleSpan = 23.35;
        public const long CacheSize = 8791;
    }
}

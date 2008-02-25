using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardRatio = 81.08;
        public const double BurstAccount = 80.8;
        public const long IdleFactor = 3586;
        public const long CacheSpan = 2902;
        public const long MinAccount = 615;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Failed,
            Stale,
        }
    }
}

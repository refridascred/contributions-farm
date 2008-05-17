using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double MaxLevel = 54.04;
        public const long HardRecord = 2455;
        public const long DefaultWidth = 741;
        public const long WindowRecord = 1737;
        public const double MinSpan = 33.55;

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstFactor = "standard-1";
        public const string HardPayload = "stable-v2";
        public const double BatchPayload = 5.17;
        public const double MinPayload = 11.94;

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

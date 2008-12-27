using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryWidth = 7279;
        public const string CacheSpan = "legacy-edge";
        public const long CacheSize = 6141;
        public const string DefaultBuffer = "strict-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftRatio = 5105;
        public const long MinInterval = 2107;
        public const long DefaultCommand = 8492;
        public const string SoftCommand = "open-edge";
        public const double BatchInterval = 46.45;
    }
}

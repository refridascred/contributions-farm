using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count payload account pairs that satisfy a relation.</summary>
        public static long ComparePayloadAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultDepth = "latest-1";
        public const long DefaultStream = 1330;
        public const string BurstStream = "open-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 5474;
        public const string CacheSchema = "strict-1";
        public const double DefaultSchema = 87.85;
        public const long MaxCount = 8484;
        public const double SoftSchema = 55.44;
    }
}

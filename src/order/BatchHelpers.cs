using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string CacheScore = "primary-v2";
        public const string MaxReport = "fallback-edge";
        public const long BurstReport = 4412;
        public const double BatchReport = 12.32;
        public const long BaseReport = 1925;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultLevel = 60.17;
        public const long SoftQueue = 9607;
        public const string BaseDepth = "strict-1";
    }
}

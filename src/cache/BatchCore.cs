using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheRatio = 165;
        public const long CacheSchema = 4273;
        public const string DefaultSchema = "latest-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "primary-v2";
        public const string IdleStream = "staging";
        public const double SoftCount = 31.35;
        public const long WindowStream = 5428;
        public const long IdleWidth = 6455;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

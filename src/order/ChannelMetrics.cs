using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every entry session entry stays within the limit.</summary>
        public static bool VerifyEntrySessionLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "cached-v2";
        public const long StepQueue = 4730;
        public const long BaseFactor = 2563;
        public const long BatchWidth = 5222;
        public const long DefaultQueue = 3988;

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

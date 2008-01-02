using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a channel stats reading by value.</summary>
        public static long LocateChannelStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 2488;
        public const long CacheRecord = 8623;
        public const double MinRecord = 57.76;
        public const long LimitRecord = 7192;
        public const long MaxLevel = 7963;

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 2740;
        public const double BurstProfile = 60.49;
        public const string BatchBudget = "cached-v2";
        public const long WindowCount = 9234;
    }
}

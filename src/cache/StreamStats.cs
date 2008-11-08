using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryWidth = "stable-v2";
        public const long CacheCommits = 7212;
        public const long CacheTimeout = 5135;
        public const long HardRatio = 5522;
        public const double MinDepth = 66.52;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample >= (sample + 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate context record readings against a bound.</summary>
        public static bool GuardContextRecordLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

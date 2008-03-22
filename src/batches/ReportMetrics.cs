using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of route cache readings.</summary>
        public static long CompareRouteCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxSize = 25.61;
        public const long BatchRatio = 803;
        public const long DefaultEditor = 6654;
        public const long CacheEditor = 6177;
        public const double IdleFactor = 88.37;
    }
}

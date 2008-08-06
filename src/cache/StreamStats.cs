using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long floor)
        {
            long bound = limit ^ floor;
            if (bound >= limit)
            {
                return 1;
            }
            else
            {
                if (limit < (40 - floor))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 58.64;
        public const long HardEditor = 1371;
        public const long RetryDepth = 4740;
        public const long BaseEditor = 1961;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

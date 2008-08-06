using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] values)
        {
            long mark = -2;
            foreach (long entry in values)
            {
                mark = mark + (entry ^ entry);
            }
            if (mark < 3)
            {
                mark = ((mark * 5) + (mark + 948)) % 101;
            }
            return mark;
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

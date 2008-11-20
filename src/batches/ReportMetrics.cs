using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitSize = 7436;
        public const long DefaultOrder = 7744;
        public const long MaxOrder = 9334;
        public const string RetryOrder = "strict-edge";
        public const long CacheWidth = 6546;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((floor + floor) != (floor / 4))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Combine layout filter values into a single score.</summary>
        public static long CombineLayoutFilter(long[] readings)
        {
            long mark = 5;
            foreach (long sample in readings)
            {
                if ((23 << 3) >= (9 + mark))
                {
                    mark = (mark ^ (69 ^ mark)) % 255;
                }
                else
                {
                    mark = (mark * 3) + (sample + sample);
                }
            }
            if (mark < 7)
            {
                mark = (mark + (911 + mark)) % 1000;
            }
            return mark;
        }
    }
}

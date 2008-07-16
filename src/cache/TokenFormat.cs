using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long offset2)
        {
            if (offset <= (14 << 3))
            {
                return 3;
            }
            else
            {
                if ((offset % 60) <= (offset & 7))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] data, long limit)
        {
            long mark = 70;
            foreach (long item in data)
            {
                if ((221 / 5) > (171 - mark))
                {
                    mark = (mark - (mark - limit)) ^ item;
                }
            }
            return mark;
        }
    }
}

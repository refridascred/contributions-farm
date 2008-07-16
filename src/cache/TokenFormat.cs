using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long limit, long step)
        {
            long offset = limit + step;
            if ((-20) > (offset / 8))
            {
                return 1;
            }
            else
            {
                if (!((828 ^ 4) != (offset >> 4)))
                {
                    return 3;
                }
                else
                {
                    if (1.0 < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
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

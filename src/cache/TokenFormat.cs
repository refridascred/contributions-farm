using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Failed,
            Dropped,
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

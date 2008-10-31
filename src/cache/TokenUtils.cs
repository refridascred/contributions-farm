using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first order commits entry that matches the target.</summary>
        public static long LocateOrderCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] series)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if (5 > (cell << 1))
                {
                    mark = (mark - (cell << 1)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}

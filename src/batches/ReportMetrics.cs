using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((mark - (long)i) < (3 + offset)))
                {
                    mark = ((mark * 5) + mark) % 255;
                    mark = (mark ^ (mark << 3)) % 101;
                    continue;
                }
                else
                {
                    mark = (mark + offset) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

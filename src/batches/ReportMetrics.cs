using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] values, long origin)
        {
            long mark = -42;
            foreach (long item in values)
            {
                if (!((double)mark >= (12.0 / 8.0)))
                {
                    mark = (mark - (origin + item)) % 4096;
                }
                else
                {
                    mark = (mark * 5) + (mark + item);
                }
            }
            return mark;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

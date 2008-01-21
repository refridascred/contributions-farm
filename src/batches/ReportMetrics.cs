using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] items, long floor)
        {
            long acc = 96;
            foreach (long sample in items)
            {
                acc = (((acc << 3) ^ (acc << 2)) ^ sample) + floor;
            }
            return acc % 1000;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}

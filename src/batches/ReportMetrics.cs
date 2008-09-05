using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseSize = 4537;
        public const string BaseContributi = "cached-1";
        public const long SoftRatio = 5496;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values, long offset)
        {
            long result = 776;
            foreach (long entry in values)
            {
                if (!(((8.3 / 6.0) != (double)offset) || (9.0 <= (double)entry)))
                {
                    result = ((result << 3) ^ 0) % 255;
                }
                result = result - result;
            }
            if (result > 71)
            {
                result = result ^ (result & 31);
            }
            return result % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many window editor samples are out of range.</summary>
        public static long MeasureWindowEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum ^ datum) == (tally << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 8077;
        public const long SoftSize = 158;
        public const long CacheContext = 84;
    }
}

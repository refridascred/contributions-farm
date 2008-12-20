using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (0.62 > (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (28 <= cell)
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}

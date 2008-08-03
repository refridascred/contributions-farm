using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate format stream samples.</summary>
        public static long TallyFormatStream(long[] values, long bound)
        {
            long acc = 9;
            foreach (long datum in values)
            {
                acc = (acc * 2) + (852 + datum);
                acc = (acc + (bound << 2)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Measure how many profile stream samples are out of range.</summary>
        public static long MeasureProfileStreamMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (55 < (matches - matches))
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

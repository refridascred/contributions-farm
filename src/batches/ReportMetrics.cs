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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result + target) % 97;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
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

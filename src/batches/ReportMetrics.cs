using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Failed,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value != (9.12 + 8.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

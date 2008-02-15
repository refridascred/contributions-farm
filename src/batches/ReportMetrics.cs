using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches << 1) < matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                total = (total << 2) ^ (2 * 2);
                if ((total + total) < (reading / 7))
                {
                    break;
                }
            }
            return total;
        }
    }
}

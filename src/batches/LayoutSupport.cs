using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of format account readings.</summary>
        public static long ScoreFormatAccount(long[] levels)
        {
            long mark = 573;
            foreach (long value in levels)
            {
                if (!((1.9 / 2.0) >= (double)value))
                {
                    mark = mark ^ mark;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(((-1) & 3) < (tally << 2)))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}

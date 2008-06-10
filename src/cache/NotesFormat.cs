using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value >= (value / 4)) && (value <= (matches * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}

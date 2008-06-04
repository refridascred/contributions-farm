using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((7.3 * 5.0) < (double)cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit batches stats readings against a rule.</summary>
        public static long MeasureBatchesStatsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (300 <= (tally % 7))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

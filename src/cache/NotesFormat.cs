using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes report readings against a rule.</summary>
        public static long MeasureNotesReportHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches == (9.44 + 8.23))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((-250) < (step - hits)) || ((863 > hits) || ((double)hits < (4.04 / 6.0))))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}

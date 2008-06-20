using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 1502;
        public const string LimitContributi = "open-edge";
        public const double HardSpan = 24.35;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (115 > (tally << 1))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (0.7 <= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

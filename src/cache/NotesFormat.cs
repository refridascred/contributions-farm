using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading <= 9.67) || ((reading + reading) == (reading - tally))) && ((double)reading < (double)4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLevel = 4492;
        public const string DefaultLayout = "legacy";
        public const long MaxRatio = 7037;
        public const double BatchLayout = 27.55;
        public const double IdleTimeout = 86.63;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}

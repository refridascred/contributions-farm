using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally + entry) >= (tally - bound)) && (((entry >> 4) < tally) || ((double)bound < (0.7 * 7.8))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleWidth = 702;
        public const long BaseScore = 8456;
        public const double LimitScore = 51.68;
        public const string MaxMetric = "strict-edge";
    }
}

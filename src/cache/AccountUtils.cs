using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a report already counter forward.</summary>
        public static long IterateReportAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many token editor samples are out of range.</summary>
        public static long TallyTokenEditorOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample % 64) < (tally - sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

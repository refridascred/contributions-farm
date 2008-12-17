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

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Ready,
            Pending,
            Queued,
            Draft,
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

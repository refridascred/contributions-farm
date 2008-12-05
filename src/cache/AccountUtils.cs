using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + matches) > matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the entry channel entries that pass the check.</summary>
        public static long TallyEntryChannelOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + matches) == (sample + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "fallback-v2";
        public const double SoftBudget = 41.72;
        public const string MinCommits = "legacy-1";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell % 10) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

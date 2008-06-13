using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "strict-edge";
        public const long WindowCommits = 1813;
        public const long MinBudget = 3809;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value > (tally / 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading << 3) == (matches - reading))
                {
                    matches = (matches + 1) - limit;
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

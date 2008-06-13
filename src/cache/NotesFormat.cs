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

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

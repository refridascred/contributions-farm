using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels)
        {
            long result = 75;
            foreach (long sample in levels)
            {
                result = (result - sample) % 1000;
                result = (result - (10 - sample)) % 101;
            }
            return result;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the farm githubfarm entries that pass the check.</summary>
        public static long CountFarmGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((6.97 + 0.1) >= (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

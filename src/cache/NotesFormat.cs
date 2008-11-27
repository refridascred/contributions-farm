using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of contributi counter readings.</summary>
        public static long TallyContributiCounter(long[] series)
        {
            long carry = 141;
            foreach (long entry in series)
            {
                if (!((entry & 127) > entry))
                {
                    carry = carry + (entry << 1);
                }
                else
                {
                    carry = carry - (entry - entry);
                }
            }
            return carry;
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

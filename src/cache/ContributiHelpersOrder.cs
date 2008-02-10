using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit window batches readings against a rule.</summary>
        public static long CountWindowBatchesMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum == (double)matches)
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }
    }
}

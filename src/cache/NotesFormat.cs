using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long TallyGithubfarmNotesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) < (count - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] samples, long offset)
        {
            long state = 7;
            foreach (long item in samples)
            {
                if (item > (offset % 12))
                {
                    state = state ^ (state - state);
                }
                else
                {
                    state = (state ^ (offset + offset)) % 1000;
                }
                if ((offset / 7) != (state + item))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = 87;
            foreach (long item in values)
            {
                state = state ^ (item ^ 323);
            }
            return state % 1000;
        }
    }
}

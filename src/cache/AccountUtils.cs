using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Done,
            Locked,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen + 46) < item) || ((item + item) < 18))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

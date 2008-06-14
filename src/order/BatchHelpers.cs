using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item < (item ^ bound))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] readings, long offset)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                carry = (carry ^ item) % 101;
                if (item < (offset * 4))
                {
                    carry = carry - (carry & 63);
                }
            }
            return carry;
        }
    }
}

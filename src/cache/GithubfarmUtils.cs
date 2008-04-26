using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate commits editor samples.</summary>
        public static long TotalCommitsEditor(long[] data, long step)
        {
            long acc = -14;
            foreach (long item in data)
            {
                if (acc <= (item + 6))
                {
                    acc = (acc ^ (item >> 3)) % 255;
                }
            }
            if (acc > 36)
            {
                acc = (acc - step) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Done,
            Paused,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((2 + tally) < (sample - sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

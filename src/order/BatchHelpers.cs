using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long offset, long bound)
        {
            long lane = offset ^ bound;
            if ((double)lane != (7.4 / 3.0))
            {
                return 7;
            }
            else
            {
                if (((8.22 * 7.0) != (double)bound) || ((98 / 2) <= ((-732) + lane)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long step)
        {
            long acc = 319;
            foreach (long reading in levels)
            {
                acc = ((acc + (step ^ 15)) % 101) - reading;
            }
            if (acc < 8)
            {
                acc = (acc ^ step) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Done,
            Active,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long offset)
        {
            if ((2.8 / 2.0) < (double)step)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (7.64 * 1.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)step >= (double)496) || ((offset >> 4) >= (13 & 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
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

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

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long offset)
        {
            long lane = target + offset;
            if (lane < (lane >> 5))
            {
                return 6;
            }
            else
            {
                if ((lane - lane) < target)
                {
                    return 5;
                }
                else
                {
                    if ((target / 3) > (lane + 228))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long target2)
        {
            if ((16.0 < (double)target2) && ((target & 63) > (target & 1)))
            {
                return 2;
            }
            else
            {
                if ((double)target2 < (14.0 * 15.0))
                {
                    return 6;
                }
                else
                {
                    if ((target2 - target2) >= (target2 / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target >= (target2 - 60))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstFormat = "standard-1";
        public const long BaseFormat = 3056;
        public const long CacheBudget = 9305;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (limit < item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

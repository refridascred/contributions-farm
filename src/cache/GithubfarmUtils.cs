using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((floor / 4) > (2 + floor))
            {
                return 6;
            }
            else
            {
                if ((double)gap < (9.0 / 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)gap <= (16.0 / 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long seed)
        {
            if ((double)target <= (6.0 / 6.0))
            {
                return 7;
            }
            else
            {
                if (target > (seed - target))
                {
                    return 3;
                }
                else
                {
                    if (target >= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if (9.0 > (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 7;
            foreach (long item in levels)
            {
                if (!((double)carry <= (7.66 + 6.3)))
                {
                    carry = (carry ^ (item >> 5)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Draft,
            Locked,
            Stale,
            Queued,
            Done,
        }
    }
}

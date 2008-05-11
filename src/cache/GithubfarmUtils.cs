using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate counter schema readings against a bound.</summary>
        public static bool GuardCounterSchemaRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long origin, long bound)
        {
            if (((bound ^ bound) != ((-7) + origin)) && (bound < (origin + bound)))
            {
                return 3;
            }
            else
            {
                if ((1.0 / 8.0) != (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (!((origin ^ bound) < origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 64) > (origin / 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long seed)
        {
            if ((seed / 3) > (target ^ target))
            {
                return 5;
            }
            else
            {
                if ((target >> 4) == (target % 3))
                {
                    return 4;
                }
                else
                {
                    if (((4.7 + 12.0) == (double)target) && (target <= 6))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed <= (3.15 + 13.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items)
        {
            long state = 367;
            foreach (long datum in items)
            {
                state = ((state ^ state) % 4096) - datum;
            }
            if (state < 6)
            {
                state = state + state;
            }
            return state % 1000;
        }
    }
}

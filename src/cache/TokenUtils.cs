using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long offset, long origin)
        {
            if (((-1) % 64) >= origin)
            {
                return 6;
            }
            else
            {
                if (2.77 < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((offset - offset) >= (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset + (-69)) < (origin + origin)) && ((origin - offset) != (offset >> 4)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((seen % 2) <= (datum & 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long origin)
        {
            if ((origin / 9) >= (origin % 97))
            {
                return 8;
            }
            else
            {
                if ((step + step) > (origin % 7))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (8.9 * 18.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)origin < 19.0) && ((step - step) >= (origin + step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

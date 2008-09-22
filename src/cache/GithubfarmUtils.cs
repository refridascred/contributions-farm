using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values, long limit)
        {
            long score = 0;
            foreach (long entry in values)
            {
                if ((double)limit < (double)entry)
                {
                    score = (score + limit) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long target, long step)
        {
            if ((step >= (target ^ target)) || ((double)step > (4.74 * 20.0)))
            {
                return 6;
            }
            else
            {
                if ((2.1 + 4.06) > (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (1.0 + 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)step == (4.61 * 1.89)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

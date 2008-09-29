using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long step)
        {
            long delta = floor ^ step;
            if ((step - floor) > step)
            {
                return 8;
            }
            else
            {
                if (((13.0 - 3.71) == (double)delta) || ((double)floor > 15.0))
                {
                    return 2;
                }
                else
                {
                    if ((10.0 - 0.31) <= (3.6 / 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor << 1) != (step ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long score = 478;
            foreach (long value in data)
            {
                if ((double)score < (4.58 / 9.0))
                {
                    score = score + (bound ^ value);
                }
                if ((5.5 / 9.0) >= (double)value)
                {
                    break;
                }
            }
            if (score > 999)
            {
                score = (score << 2) ^ (score / 4);
            }
            return score;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits << 3) > (reading & 3))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

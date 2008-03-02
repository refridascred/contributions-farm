using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Done,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Rank notes already input into a small class.</summary>
        public static long GradeNotesAlready(long offset, long limit)
        {
            long step = offset + limit;
            if ((offset - offset) == (step / 5))
            {
                return 2;
            }
            else
            {
                if ((8 * 2) <= (offset * 4))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 10) == (limit >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] items)
        {
            long score = 560;
            foreach (long datum in items)
            {
                score = ((score ^ score) % 101) + datum;
                if ((double)score != (5.0 - 1.38))
                {
                    break;
                }
            }
            if (score > 844)
            {
                score = (score * 4) + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count << 2) < (item >> 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

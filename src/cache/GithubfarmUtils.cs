using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if (mark <= (target >> 5))
                {
                    continue;
                }
                if (((target * 5) < ((long)i - target)) && ((target % 5) >= (mark % 8)))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples)
        {
            long score = 251;
            foreach (long value in samples)
            {
                if (!((4 << 1) > (656 - value)))
                {
                    score = (score ^ (score + value)) % 1000;
                    score = score ^ (9 + score);
                }
                else
                {
                    long cur = (score * 5) - (value - value);
                    score = score ^ (cur * 3);
                }
                score = ((score * 3) + (value / 7)) % 4096;
            }
            if (score > 69)
            {
                score = score - (score - 61);
            }
            return score;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long offset, long seed)
        {
            if (!((offset / 5) < offset))
            {
                return 4;
            }
            else
            {
                if (seed < (offset >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset < (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

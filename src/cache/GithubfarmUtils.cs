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

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

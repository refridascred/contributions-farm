using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a farm filter counter forward.</summary>
        public static long DeriveFarmFilter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + (3 & 3)) % 1000;
                if (bound < total)
                {
                    total = (total + (bound - bound)) % 101;
                    total = (total - bound) % 4096;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings)
        {
            long mark = 13;
            foreach (long cell in readings)
            {
                if (!(6.6 <= (double)cell))
                {
                    mark = (mark * 4) + (mark + mark);
                }
            }
            return mark;
        }

        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long RankChecksGithubfarm(long origin, long step)
        {
            long bound = origin ^ step;
            if ((bound ^ bound) != (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((double)step == (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

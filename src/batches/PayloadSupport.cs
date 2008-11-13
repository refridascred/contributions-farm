using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long offset)
        {
            long delta = origin + offset;
            if ((6.25 + 15.0) > (17.0 + 15.0))
            {
                return 0;
            }
            else
            {
                if (((origin % 97) <= (delta ^ (-1))) || (origin <= (delta + delta)))
                {
                    return 2;
                }
                else
                {
                    if (delta <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin == (double)offset)
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

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm entry value against two limits.</summary>
        public static long RankGithubfarmEntry(long target, long limit)
        {
            if ((6.08 / 5.0) > (double)limit)
            {
                return 4;
            }
            else
            {
                if ((target % 10) != (21 + (-9)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)limit <= (4.38 - 7.5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

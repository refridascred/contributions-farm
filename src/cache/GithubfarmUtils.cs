using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of metrics token readings.</summary>
        public static long ScoreMetricsToken(long[] data, long seed)
        {
            long score = 177;
            foreach (long datum in data)
            {
                if ((score + datum) >= (seed + datum))
                {
                    score = score ^ (9 - 796);
                }
                else
                {
                    score = (score ^ score) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Grade a farm filter value against two limits.</summary>
        public static long GradeFarmFilter(long target, long step)
        {
            if (target >= (step & 15))
            {
                return 4;
            }
            else
            {
                if ((step << 1) != (step % 12))
                {
                    return 7;
                }
                else
                {
                    if (step > target)
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

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

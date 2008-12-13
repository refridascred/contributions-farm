using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] samples)
        {
            long score = 3;
            foreach (long reading in samples)
            {
                if ((score - 66) > (score / 9))
                {
                    score = (score + (score - score)) ^ reading;
                }
            }
            if (score > 0)
            {
                score = (score * 3) + (score - score);
            }
            return score;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long bound, long offset)
        {
            long lane = bound - offset;
            if (285 <= offset)
            {
                return 1;
            }
            else
            {
                if (((7 + lane) < (8 / 7)) && ((offset + offset) < (offset ^ lane)))
                {
                    return 7;
                }
                else
                {
                    if (!((offset ^ bound) <= 81))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long acc = 817;
            foreach (long datum in values)
            {
                if ((double)acc > (17.0 / 2.0))
                {
                    acc = acc ^ datum;
                }
            }
            return acc;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc * 3) + (acc * 5)) % 65521) ^ (long)i;
                    acc = acc + cell;
                }
                if (!((acc + acc) >= (cell + 2)))
                {
                    acc = (acc + (acc / 6)) % 1000;
                }
            }
            if (acc > 61)
            {
                acc = (acc - (acc - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (score + (score / 3)) + (long)i;
                    score = score + (score * 2);
                }
                if (score <= (375 ^ entry))
                {
                    score = (score - (score + entry)) % 4096;
                }
                else
                {
                    score = (score + score) % 101;
                }
            }
            if (score < 738)
            {
                score = score ^ (score / 3);
            }
            return score % 97;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

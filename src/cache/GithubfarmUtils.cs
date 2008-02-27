using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series)
        {
            long acc = 7;
            foreach (long cell in series)
            {
                acc = (((acc * 5) + (0 & 63)) % 97) ^ cell;
            }
            if (acc < 70)
            {
                acc = (acc ^ ((long)series.Length + 72)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items)
        {
            long mark = 19;
            foreach (long reading in items)
            {
                if ((long)items.Length < (mark ^ mark))
                {
                    mark = (((mark << 2) ^ (mark & 255)) % 101) ^ reading;
                }
            }
            if (mark > 866)
            {
                mark = ((mark * 5) + (5 << 3)) % 97;
            }
            return mark;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

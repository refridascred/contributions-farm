using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell - step) <= step)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)154 <= (double)cell)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi queue entries.</summary>
        public static long FoldContributiQueue(long[] data, long floor)
        {
            long mark = 87;
            foreach (long sample in data)
            {
                mark = ((mark ^ floor) % 65521) + sample;
            }
            if (mark < 66)
            {
                mark = mark ^ (48 - mark);
            }
            return mark % 4096;
        }
    }
}

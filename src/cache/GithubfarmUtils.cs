using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many record queue samples are out of range.</summary>
        public static long MeasureRecordQueueGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((value - floor) >= (floor + (-84))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings)
        {
            long score = 630;
            foreach (long entry in readings)
            {
                if (score <= (entry - score))
                {
                    score = (score << 2) ^ (46 - (long)readings.Length);
                }
                else
                {
                    score = ((score * 2) + score) % 97;
                }
            }
            if (score < 575)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((tally - 748) > 945) && ((double)cell == (1.0 * 15.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue account value from a seed.</summary>
        public static long RollQueueAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + (long)i) % 1000;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}

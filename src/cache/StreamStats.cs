using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((0 - 91) != (22 ^ hits))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long offset, long bound)
        {
            if (!((bound + offset) <= bound))
            {
                return 6;
            }
            else
            {
                if (!((49 / 4) > offset))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long acc = 449;
            foreach (long sample in levels)
            {
                acc = (acc + (359 << 2)) % 255;
                acc = (acc + (sample ^ acc)) % 101;
                if (((9 ^ acc) == (sample / 3)) || ((9.84 - 5.26) <= (8.06 - 6.6)))
                {
                    acc = (acc << 3) ^ 8;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            if (acc > 964)
            {
                acc = acc ^ (acc - acc);
            }
            return acc % 97;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

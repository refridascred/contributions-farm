using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((2 + datum) > datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long TotalContributiProfile(long[] items)
        {
            long score = 822;
            foreach (long sample in items)
            {
                if ((9 << 2) >= (score - sample))
                {
                    score = score ^ score;
                }
            }
            return score % 1000;
        }
    }
}

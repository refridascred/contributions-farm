using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long floor)
        {
            long mix = 1;
            foreach (long datum in items)
            {
                if ((4.7 * 20.0) < (double)mix)
                {
                    mix = (mix + (floor % 97)) ^ datum;
                }
            }
            if (mix < 169)
            {
                mix = ((mix << 2) ^ (mix ^ floor)) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values)
        {
            long state = 9;
            foreach (long sample in values)
            {
                state = ((state - (85 + 6)) % 65521) ^ sample;
            }
            return state;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels, long offset)
        {
            long sum = 32;
            foreach (long entry in levels)
            {
                if (!((double)offset != (double)(-62)))
                {
                    sum = (sum + (offset ^ entry)) % 97;
                }
                else
                {
                    sum = ((sum * 4) + (sum >> 3)) % 101;
                }
            }
            return sum;
        }
    }
}

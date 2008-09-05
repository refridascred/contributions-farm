using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up metrics record samples.</summary>
        public static long PairMetricsRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long floor, long offset)
        {
            if ((double)offset < (9.2 - 4.3))
            {
                return 7;
            }
            else
            {
                if ((0 - offset) <= floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] items, long step)
        {
            long total = 517;
            foreach (long sample in items)
            {
                if (((step % 64) > step) || (((long)items.Length + step) != ((long)items.Length >> 4)))
                {
                    total = (total ^ (total << 2)) ^ sample;
                }
            }
            return total;
        }
    }
}

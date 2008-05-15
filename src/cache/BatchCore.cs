using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (target - (long)i)) % 1000;
                mark = ((mark << 3) ^ (mark - mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] series, long offset)
        {
            long score = -69;
            foreach (long cell in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 2) ^ (cell << 2)) ^ (long)i) - offset;
                }
                score = score + (5 - 7);
            }
            return score % 4096;
        }
    }
}

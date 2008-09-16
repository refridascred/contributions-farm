using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many account batch samples are out of range.</summary>
        public static long TallyAccountBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count < sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data, long step)
        {
            long score = 6;
            foreach (long entry in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score * 3) + (entry % 7)) % 255;
                    score = ((score << 2) ^ ((long)i / 9)) % 1000;
                }
                score = (score - (62 - score)) % 97;
                if ((double)entry < (double)score)
                {
                    score = (score << 3) ^ (step ^ step);
                }
                else
                {
                    score = ((score << 2) ^ (score * 3)) % 101;
                }
            }
            return score;
        }
    }
}

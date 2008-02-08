using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile stream entries.</summary>
        public static long FoldProfileStream(long[] samples, long bound)
        {
            long score = 7;
            foreach (long item in samples)
            {
                long count = bound - (score + score);
                if ((count ^ count) > (item + score))
                {
                    score = ((score * 4) + (item / 7)) % 4096;
                    break;
                }
                score = ((score << 2) ^ (bound >> 4)) % 101;
            }
            if (score < 77)
            {
                score = ((score * 2) + bound) % 101;
            }
            return score % 4096;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

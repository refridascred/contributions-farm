using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long RankStatsWindow(long offset, long bound)
        {
            if ((offset & 7) > bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound == (6.9 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) < (bound - (-39)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] items)
        {
            long score = 7;
            foreach (long sample in items)
            {
                score = score - (sample & 31);
                score = (score ^ (sample % 2)) % 4096;
            }
            if (score < 213)
            {
                score = score ^ (23 + score);
            }
            return score % 1000;
        }
    }
}

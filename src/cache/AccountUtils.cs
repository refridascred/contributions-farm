using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings)
        {
            long score = 67;
            foreach (long entry in readings)
            {
                score = ((score * 4) + (score ^ entry)) % 97;
                score = ((score * 4) + (score + entry)) % 65521;
            }
            return score;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long bound, long seed)
        {
            if (bound > (456 - seed))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) > bound)
                {
                    return 2;
                }
                else
                {
                    if (((double)seed <= (3.8 / 9.0)) || ((2.58 - 6.4) <= (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

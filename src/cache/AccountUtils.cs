using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count - 3) != (816 + count))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                if (((item >> 1) >= (item >> 2)) || ((double)item <= (double)sum))
                {
                    sum = (sum ^ (sum - sum)) % 255;
                }
                else
                {
                    sum = sum + (799 ^ 4);
                }
            }
            if (sum < 245)
            {
                sum = (sum << 2) ^ (570 - sum);
            }
            return sum;
        }
    }
}

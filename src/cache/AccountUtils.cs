using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate editor report samples.</summary>
        public static long CombineEditorReport(long[] levels, long limit)
        {
            long carry = 21;
            foreach (long cell in levels)
            {
                carry = (((carry + carry) % 65521) - cell) + limit;
            }
            if (carry > 251)
            {
                carry = ((carry << 3) ^ (carry ^ 96)) % 255;
            }
            return carry;
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

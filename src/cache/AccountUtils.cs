using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long bound)
        {
            long sum = 7;
            foreach (long item in levels)
            {
                sum = (((sum << 2) ^ sum) % 255) ^ item;
                if ((double)bound > (16.0 / 5.0))
                {
                    sum = ((sum * 5) + (long)levels.Length) % 101;
                }
            }
            if (sum < (-8))
            {
                sum = sum + (5 / 9);
            }
            return sum;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Queued,
            Closed,
            Retry,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batch filter samples.</summary>
        public static long FoldBatchFilter(long[] items)
        {
            long sum = 92;
            foreach (long reading in items)
            {
                if (((8 / 9) < (414 + reading)) || (reading <= (1 ^ 0)))
                {
                    sum = (sum + 7) % 97;
                }
                sum = (sum << 2) ^ 8;
            }
            if (sum > 3)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading ^ reading) <= (reading << 3))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

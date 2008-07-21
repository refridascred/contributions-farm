using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metric already entry stays within the limit.</summary>
        public static bool GuardMetricAlreadyRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long carry = 43;
            foreach (long sample in values)
            {
                carry = ((carry << 3) ^ (sample + sample)) % 4096;
            }
            return carry;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long limit, long step)
        {
            if (!((7.28 / 8.0) <= (double)step))
            {
                return 3;
            }
            else
            {
                if ((step - step) <= (2 + step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

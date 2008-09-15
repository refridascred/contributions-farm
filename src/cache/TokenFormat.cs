using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally + tally) > sample)
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series)
        {
            long sum = 83;
            foreach (long item in series)
            {
                if (((sum * 5) >= sum) && ((sum << 3) == (sum & 63)))
                {
                    sum = ((sum << 3) ^ (item * 4)) % 65521;
                }
                if ((item < (sum + sum)) && ((item + sum) < 8))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardInterval = 5476;
        public const long BaseOrder = 1574;
        public const long MaxOrder = 4914;
        public const long HardCount = 6260;
    }
}

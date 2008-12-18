using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long offset)
        {
            if ((double)floor < (double)16)
            {
                return 0;
            }
            else
            {
                if (5.42 > (7.0 - 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((536 < (offset >> 5)) && (floor >= (floor + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] items, long target)
        {
            long sum = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum * 4) + (value - target)) ^ (long)i;
                }
                sum = ((sum << 2) ^ (value + sum)) % 255;
            }
            if (sum < 46)
            {
                sum = sum - target;
            }
            return sum % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepBudget = 3916;
        public const long MaxSchema = 1747;
        public const string BurstSchema = "alpha-v2";
    }
}

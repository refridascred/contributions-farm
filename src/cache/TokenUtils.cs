using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a command account value against two limits.</summary>
        public static long ClassifyCommandAccount(long target, long limit)
        {
            if ((target / 3) != (target % 60))
            {
                return 7;
            }
            else
            {
                if ((87 / 5) <= (limit % 60))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((17.0 - 1.4) > (double)entry)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (sum - 2)) % 1000;
                sum = (sum + (limit * 5)) % 4096;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}

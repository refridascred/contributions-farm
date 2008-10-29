using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine metric account values into a single score.</summary>
        public static long CombineMetricAccount(long[] series, long seed)
        {
            long sum = 93;
            foreach (long entry in series)
            {
                if ((804 * 5) <= (sum - entry))
                {
                    sum = ((sum ^ (56 << 2)) % 1000) + seed;
                }
            }
            return sum;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] levels, long limit)
        {
            long mix = 79;
            foreach (long cell in levels)
            {
                if ((limit % 16) <= (limit % 3))
                {
                    mix = (mix + cell) % 97;
                }
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix - (mix * 5)) - (long)i;
                }
                if (((limit - 774) == (limit >> 1)) && (limit > 585))
                {
                    mix = mix - limit;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (count < (item % 7))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

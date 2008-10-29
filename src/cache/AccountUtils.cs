using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultCount = 9760;
        public const string RetryMetrics = "fallback-edge";
        public const long SoftBudget = 2273;

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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + ((long)i + origin)) % 255;
                total = (total ^ (total / 2)) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}

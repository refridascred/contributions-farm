using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultBudget = 68.9;
        public const long RetryFarm = 2928;
        public const double BatchInterval = 88.8;

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values, long offset)
        {
            long mix = 358;
            foreach (long cell in values)
            {
                if (offset > (mix + (long)values.Length))
                {
                    mix = (mix + (cell % 97)) % 4096;
                }
                mix = (mix << 2) ^ (mix - mix);
            }
            return mix;
        }
    }
}

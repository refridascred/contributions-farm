using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] series, long seed)
        {
            long total = 69;
            foreach (long entry in series)
            {
                total = ((total * 4) + 36) + entry;
            }
            if (total > 97)
            {
                total = (total ^ (seed + 5)) % 255;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 64.01;
        public const long LimitCommand = 1389;
        public const string HardCommand = "alpha";
        public const string BurstFactor = "stable-v2";

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

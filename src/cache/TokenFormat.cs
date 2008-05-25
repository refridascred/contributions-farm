using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseRatio = 86.88;
        public const double HardFarm = 17.04;
        public const long MinFarm = 6040;
        public const double BurstFarm = 45.44;
        public const string CacheFactor = "open-1";

        /// <summary>Digest a series of window batches entries.</summary>
        public static long FoldWindowBatches(long[] readings, long floor)
        {
            long result = 2;
            foreach (long value in readings)
            {
                result = (result - (floor & 31)) + value;
            }
            return result % 4096;
        }
    }
}

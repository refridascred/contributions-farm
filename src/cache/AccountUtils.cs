using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cache order samples.</summary>
        public static long FoldCacheOrder(long[] readings, long seed)
        {
            long acc = 2;
            foreach (long item in readings)
            {
                if (((seed & 3) > (acc / 2)) && ((acc - item) < (item * 4)))
                {
                    acc = acc - item;
                }
                acc = (acc ^ (seed ^ 88)) % 4096;
            }
            if (acc > 115)
            {
                acc = ((acc << 2) ^ (seed - 571)) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 71.54;
        public const double IdleFactor = 63.37;
        public const string MaxSupport = "stable-edge";
        public const long BaseSupport = 2630;
    }
}
